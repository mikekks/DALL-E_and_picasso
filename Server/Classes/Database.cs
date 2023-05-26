using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
// using Server.Classes.Tables;
using DalleLib;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using DalleLib.InGame;
using Org.BouncyCastle.Security;

namespace Server.Classes
{
    static class Database
    {
        // 외래키 제약 조건 : 종속하는 테이블의 PK가 먼저 만들어 지지 않으면 행 추가 x 
        //  ex. Records 테이블에 행 추가하려면 userId(Users) -> questionId(Dalle) -> roomId(Rooms)의 PK들끼리 종속관계 성립해야 함
        public static string _server = "localhost";
        public static int _port = 3306;
        public static string _database = "test05261217";
        public static string _id = "root";
        public static string _pw = "00000000";
        public static string _connectionAddress = "";

        public static MySqlConnection mysql = new MySqlConnection(string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw));

        public static Boolean connect()
        {
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    Console.WriteLine("DB연결 성공");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB연결 실패" + ex);
                return true;
            }
        }

        // 1. 회원가입하는 함수
        public static bool signUp(string userId, string password, string recovery_Q, string recovery_A, DateTime regDate)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Users VALUES (@userId, @roomId, @password, @recovery_Q, @recovery_A, @ready, @Tier, @regDate)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@roomId", null);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@recovery_Q", recovery_Q);
                cmd.Parameters.AddWithValue("@recovery_A", recovery_A);
                cmd.Parameters.AddWithValue("@ready", null);
                cmd.Parameters.AddWithValue("@Tier", null);
                cmd.Parameters.AddWithValue("@regDate", regDate);

                Console.WriteLine("회원가입 성공");
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("회원가입 실패" + ex);
                // 동일한 userId 존재합니다. (PK)
                return false;
            }
        }

        // 2. 로그인하는 함수
        public static User login(string userId, string password)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Users WHERE Users.userId = '{userId}'";

            List<User> users = new List<User>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        string roomId = rdr.IsDBNull(rdr.GetOrdinal("roomId")) ? string.Empty : rdr.GetString("roomId");
                        bool ready = !rdr.IsDBNull(rdr.GetOrdinal("ready")) && rdr.GetBoolean("ready");
                        string tier = rdr.IsDBNull(rdr.GetOrdinal("Tier")) ? string.Empty : rdr.GetString("Tier");

                        users.Add(new User(
                                    rdr.GetString("userId"),
                                    roomId,
                                    rdr.GetString("password"),
                                    rdr.GetString("recovery_Q"),
                                    rdr.GetString("recovery_A"),
                                    ready,
                                    tier,
                                    rdr.GetDateTime("regDate")));
                    }
                }

                if (users[0].password == password) // userId를 갖고 있는 사람
                {
                    Console.WriteLine("로그인 성공");
                    Console.WriteLine(users[0].userId);
                    return users[0];
                }

                Console.WriteLine(users.Count);
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("로그인 실패" + ex);
                // userId 혹은 password 미일치
                return null;
            }
        }

        // 10. 문제 만드는 함수
        public static bool makeDalleQuestion(int questionId, string imageUrl, string keyword_1, string keyword_2, string keyword_3)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Dalle VALUES (@questionId, @imageUrl, @keyword_1, @keyword_2, @keyword_3)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@questionId", questionId);
                cmd.Parameters.AddWithValue("@imageUrl", imageUrl);
                cmd.Parameters.AddWithValue("@keyword_1", keyword_1);
                cmd.Parameters.AddWithValue("@keyword_2", keyword_2);
                cmd.Parameters.AddWithValue("@keyword_3", keyword_3);

                Console.WriteLine("문제 만들기 성공");
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("문제 만들기 실패" + ex);
                // 동일한 roomId가 존재합니다. (PK)
                return false;
            }
        }

        // 4-1. 방 만드는 함수
        public static bool makeNewRoom(string roomId, string userId, int questionId, int totalNum, int level)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Rooms VALUES (@roomId, @userId, @questionId, @nowPlaying, @currentNum, @totalNum, @level)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@questionId", questionId);
                cmd.Parameters.AddWithValue("@nowPlaying", 0);
                cmd.Parameters.AddWithValue("@currentNum", 0);
                cmd.Parameters.AddWithValue("@totalNum", totalNum);
                cmd.Parameters.AddWithValue("@level", level);

                Console.WriteLine("방 만들기 성공");
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("방 만들기 실패" + ex);
                return false;
            }
        }

        // 4-2 방 리스트 가져오기
        public static List<Room> getRoomsList()
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Rooms";

            List<Room> rooms = new List<Room>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        rooms.Add(new Room(
                                    rdr.GetString("roomId"),
                                    rdr.GetString("userId"),
                                    rdr.GetInt32("questionId"),
                                    rdr.GetBoolean("nowPlaying"),
                                    rdr.GetInt32("currentNum"),
                                    rdr.GetInt32("totalNum"),
                                    rdr.GetInt32("level")));
                    }
                }
                Console.WriteLine("방 리스트 가져오기 성공");
                return rooms;
            }
            catch (Exception ex)
            {
                Console.WriteLine("방 리스트 가져오기 실패" + ex);
                return null;
            }
        }

        // 5. 방 진입여부 확인하는 함수
        public static bool checkEnterRoom(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT totalNum - currentNum AS canEnterRoom FROM Rooms WHERE roomId = '{roomId}'";

            List<Room> rooms = new List<Room>();

            using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
            {

                if (rdr.Read() && rdr.GetInt32("canEnterRoom") > 0)
                {
                    Console.WriteLine("방 진입하기 성공");
                    return true;
                }

                Console.WriteLine("방 진입하기 실패");
                return false;
            }
        }


        // 6. 방 진입시 getSpecificRooms가 호출되며 room타입 반환
        public static bool enterRoom_Rooms(string roomId, string userId)
        {
            if (Database.checkEnterRoom(roomId) == true) // 방 진입이 가능한지 확인
            {
                if (mysql.State != ConnectionState.Open)
                {
                    mysql.Open();
                }

                int currentNum = getSpecificRooms(roomId).currentNum;
                // 해당 방의 현재 인원 수 + 1 

                string query = $"UPDATE Rooms SET currentNum = {currentNum + 1} WHERE roomId = '{roomId}'";
                // 해당 방의 인원수 업데이트

                try
                {
                    using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                    {
                        rdr.Close();

                        Console.WriteLine("방 진입하기 성공");
                        Database.enterRoom_Users(roomId, userId);
                        Database.getSpecificRooms(roomId);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("방 진입하기 실패" + ex);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("인원이 다 차서 들어올 수 없음");
                return false;
            }
        }

        // 6. 방 진입하는 함수 - room 타입 반환
        public static Room getSpecificRooms(string roomId)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Rooms WHERE Rooms.roomId = '{roomId}'";

            List<Room> rooms = new List<Room>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        rooms.Add(new Room(
                                    rdr.GetString("roomId"),
                                    rdr.GetString("userId"),
                                    rdr.GetInt32("questionId"),
                                    rdr.GetBoolean("nowPlaying"),
                                    rdr.GetInt32("currentNum"),
                                    rdr.GetInt32("totalNum"),
                                    rdr.GetInt32("level")));
                    }
                }
                Console.WriteLine("특정 방 가져오기 성공");
                return rooms[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("방 리스트 가져오기 실패" + ex);
                return null;
            }
        }

        // 클라이언트 자신이 진입한 방을 업데이트 in 6번함수 (Users 테이블) 
        public static bool enterRoom_Users(string roomId, string userId)
        {

            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"UPDATE Users SET roomId = '{roomId}' WHERE userId = '{userId}'";
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("유저가 진입한 방 업데이트 성공");

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("유저가 진입한 방 업데이트 실패" + ex);
                return false;
            }
        }


        // 7. 레디하는 함수
        public static bool ready(string userId, string roomId)
        {

            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"UPDATE Users SET ready = true WHERE userId = '{userId}' && roomId = '{roomId}'";
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("레디 성공");

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("레디 실패" + ex);
                return false;
            }
        }


        // 7-1. 레디 취소하는 함수
        public static bool readyCancel(string userId, string roomId)
        {

            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"UPDATE Users SET ready = false WHERE userId = '{userId}' && roomId = '{roomId}'";
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("레디 취소");

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("레디 실패" + ex);
                return false;
            }
        }

        // 8. 해당 방 참가자의 전체 레디 확인
        public static bool checkUsersReady(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT userId, ready FROM Users WHERE roomId = '{roomId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        if (rdr.GetInt32("ready") == 1)
                        {
                            Console.WriteLine("ready 확인 성공");
                        }
                        else
                        {
                            Console.WriteLine("{0} 유저가 레디하지 않음", rdr.GetString("userId"));
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // 8-1 특정 유저가 레디했는 지 가져오는 함수

        public static bool checkSpecificUserReady(string userId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT userId, ready FROM Users WHERE userId = '{userId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        if (rdr.GetInt32("ready") == 1)
                        {
                            Console.WriteLine("{0} 레디 완료", userId);
                        }
                        else
                        {
                            Console.WriteLine("{0}는 레디 안함.", userId);
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // 8-2 List 타입으로 user의 ready 정보 가져오는 함수 
        public static List<User> checkUserReady(string userId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"SELECT userId, ready FROM Users WHERE userId = '{userId}'";

            List<User> users = new List<User>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        users.Add(new User(
                                   rdr.GetString("userId"),
                                   rdr.GetBoolean("ready")));
                    }
                    return users;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // 9. 게임 실행하는 함수
        public static bool startGame(string roomId)
        {
            if (Database.checkUsersReady(roomId) == true)
            {
                if (mysql.State != ConnectionState.Open)
                {
                    mysql.Open();
                }

                string query = $"UPDATE Rooms SET nowPlaying = true WHERE roomId = '{roomId}'";
                try
                {
                    using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                    {
                        Console.WriteLine("게임 실행");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("게임을 실행할 수 없음" + ex);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("누군가 레디를 하지 않음");
                return false;
            }
        }

        // 9-1 nowPlaying이 true면 true를 반환
        public static bool checkNowPlaying(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT roomId, nowPlaying FROM Rooms";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        if (rdr.GetBoolean("nowPlaying") == true)
                        {
                            Console.WriteLine("{0} 방 현재 게임 중", roomId);
                        }
                        else
                        {
                            Console.WriteLine("{0} 방 현재 게임 안하는 중", roomId);
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // 9-2 게임 실행하게 되면 레코드 테이블에 유저 등록
        public static bool registerRecordTable(string userId, string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Records VALUES (@userId, @roomId, @tryCount, @correctCount)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.Parameters.AddWithValue("@tryCount", 0);
                cmd.Parameters.AddWithValue("@correctCount", 0);

                Console.WriteLine("레코드 테이블에 유저 등록 성공");
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("레코드 테이블에 유저 등록 실패" + ex);
                return false;
            }
        }

        // 11. 정답 확인하는 함수 
        public static bool checkAnswer(string userId, string roomId, int questionId, string userAnswer)
        {
            Console.WriteLine(Database.getTryCount(userId: "test1", roomId: "뉴비"));
            Console.WriteLine(Database.getCorrectCount(userId: "test1", roomId: "뉴비"));

            Database.updateTryCount(userId, roomId);

            if (userAnswer == Database.getKeyword(questionId)[0].keyword_1)
            {
                Console.WriteLine("1번 키워드 정답 !");
                Database.updateCorrectCount(userId, roomId);
                return true;
            }
            else if (userAnswer == Database.getKeyword(questionId)[0].keyword_2)
            {
                Console.WriteLine("2번 키워드 정답 !");
                Database.updateCorrectCount(userId, roomId);
                return true;
            }
            else if (userAnswer == Database.getKeyword(questionId)[0].keyword_3)
            {
                Console.WriteLine("3번 키워드 정답 !");
                Database.updateCorrectCount(userId, roomId);
                return true;
            }
            else
            {
                Console.WriteLine("오답 입니다.");
                return false;
            }
        }

        // tryCount 업데이트 하는 함수 in 11번함수
        public static bool updateTryCount(string userId, string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            int tryCount = Database.getTryCount(userId, roomId) + 1;
            string query = $"UPDATE Records SET tryCount = {tryCount} WHERE userId = '{userId}' && roomId = '{roomId}'";
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("tryCount 업데이트 성공");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("tryCount 업데이트 실패" + ex);
                return false;
            }
        }

        // correctCount 업데이트 하는 함수 in 11번함수
        public static bool updateCorrectCount(string userId, string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            int correctCount = Database.getCorrectCount(userId, roomId) + 1;
            string query = $"UPDATE Records SET correctCount = {correctCount} WHERE userId = '{userId}' && roomId = '{roomId}'";
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("correctCount 업데이트 성공");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("correctCount 업데이트 실패" + ex);
                return false;
            }
        }

        // user의 tryCount 가져오기 in 11번함수
        public static int getTryCount(string userId, string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"SELECT * FROM Records WHERE userId = '{userId}' && roomId = '{roomId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        return rdr.GetInt32("tryCount");
                    }
                }
            }
            catch (Exception ex)
            {
                return 999;
            }
            return 999;
        }

        // user의 correctCount 가져오기 in 11번함수
        public static int getCorrectCount(string userId, string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"SELECT * FROM Records WHERE userId = '{userId}' && roomId = '{roomId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        return rdr.GetInt32("correctCount");
                    }
                }
            }
            catch (Exception ex)
            {
                return 999;
            }
            return 999;
        }

        // 달리 키워드 가져오기 in 11번함수
        public static List<Dalle> getKeyword(int quetionId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Dalle WHERE questionId = {quetionId}";

            List<Dalle> dalle = new List<Dalle>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("달리 키워드 가져오기 성공");
                    while (rdr.Read())
                    {
                        dalle.Add(new Dalle(
                                    rdr.GetInt32("questionId"),
                                    rdr.GetString("imageUrl"),
                                    rdr.GetString("keyword_1"),
                                    rdr.GetString("keyword_2"),
                                    rdr.GetString("keyword_3")));
                    }
                }

                return dalle;
            }
            catch (Exception ex)
            {
                Console.WriteLine("달리 키워드 가져오기 실패" + ex);
                return null;
            }
        }

        // 12. 방금 게임에 대한 기록 가져오는 함수
        public static Records getRecordLastGame(string userId, string roomId)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Records WHERE userId = '{userId}' && roomId = '{roomId}'";

            List<Records> records = new List<Records>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("방금 게임 기록 가져오기 성공");
                    while (rdr.Read())
                    {
                        records.Add(new Records(
                                    rdr.GetString("userId"),
                                    rdr.GetString("roomId"),
                                    rdr.GetInt32("tryCount"),
                                    rdr.GetInt32("correctCount")));
                    }
                }

                return records[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("방금 게임 가져오기 실패" + ex);
                // userId 혹은 password 미일치
                return null;
            }
        }
        // 12-1. 방금 게임에 대한 모든 사람의 결과를 확인하는 함수
        public static List<Records> getRecordEveryone(string roomId)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Records WHERE roomId =  '{roomId}'";

            List<Records> records = new List<Records>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("모든 사람의 결과 가져오기 성공");
                    while (rdr.Read())
                    {
                        records.Add(new Records(
                                    rdr.GetString("userId"),
                                    rdr.GetString("roomId"),
                                    rdr.GetInt32("tryCount"),
                                    rdr.GetInt32("correctCount")));
                    }
                }

                return records;
            }
            catch (Exception ex)
            {
                Console.WriteLine("모든 사람의 결과 가져오기 성공" + ex);
                return null;
            }
        }




        // 3. 본인 기록 가져오는 함수
        public static Records getRecords(string userId)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Records WHERE Records.userId = '{userId}'";

            List<Records> records = new List<Records>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        records.Add(new Records(
                                    rdr.GetString("userId"),
                                    rdr.GetString("roomId"),
                                    rdr.GetInt32("tryCount"),
                                    rdr.GetInt32("correctCount")));
                    }
                }

                return records[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("본인기록 가져오기 실패" + ex);
                // userId 혹은 password 미일치
                return null;
            }
        }

        /*
        // 1. 로그인 하는 함수 
        public static Users login(string userId, string password)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Users WHERE Users.userId = '{userId}'";

            List<Users> users = new List<Users>();

            try {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        users.Add(new Users(
                                    rdr.GetString("userId"),
                                    rdr.GetString("password"),
                                    rdr.GetString("email"),
                                    rdr.GetString("answer")));
                    }
                }
                
                if (users[0].password == password) // userId를 갖고 있는 사람
                {
                    Console.WriteLine("로그인 성공");
                    Console.WriteLine(users[0].userId);
                    return users;
                }

                Console.WriteLine(users.Count);
                return null;

            }
            catch
            {
                Console.WriteLine("로그인 실패");
                // userId 혹은 password 미일치
                return null;
            }
        }

        // 3. 방 만들기 함수
        public static bool createNewRoom(Rooms rooms)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Rooms VALUES (@roomId, @userId, @capacity)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@roomId", rooms.roomId);
                cmd.Parameters.AddWithValue("@userId", rooms.userId);
                cmd.Parameters.AddWithValue("@capacity", rooms.capacity);

                Console.WriteLine("방 만들기 성공");
                cmd.ExecuteNonQuery();

                return true;

            }
            catch
            {
                Console.WriteLine("방 만들기 실패");
                // 동일한 roomId가 존재합니다. (PK)
                return false;
            }
        }
        
        // 4. 방 리스트 불러오는 함수
        public static List<Rooms> getRoomList()
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Rooms";

            List<Rooms> rooms = new List<Rooms>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        rooms.Add(new Rooms(
                                    rdr.GetString("roomId"),
                                    rdr.GetString("userId"),
                                    rdr.GetInt32("capacity")));
                    }


                    Console.WriteLine("방 리스트 불러오기 성공");
                    Console.WriteLine(rooms.Count);
                    return rooms;
                }
            }
            catch
            {
                Console.WriteLine("방 리스트 불러오기 실패");
                return null;
            }
        }

        // 8. 해당 문제애 대한 답(키워드 3개)을 반환하는 함수
        public static List<Dalle> getDalleKeywords(string questionId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Dalle WHERE Dalle.questionId = '{questionId}'";

            List<Dalle> dalle = new List<Dalle>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        dalle.Add(new Dalle(
                                    rdr.GetString("questionId"),
                                    rdr.GetString("imageUrl"),
                                    rdr.GetString("keyword_1"),
                                    rdr.GetString("keyword_2"),
                                    rdr.GetString("keyword_3")));
                    }


                    Console.WriteLine("정답 키워드 불러오기 성공");
                    Console.WriteLine(dalle.Count);
                    return dalle;
                }
            }
            catch
            {
                Console.WriteLine("정답 키워드 불러오기 실패");
                return null;
            }
        }
        // 9-1 정답 확인 함수 
        public static bool checkRightAnswer(string questionId, string answer)
        {
            List<Dalle> rightDalleAnswer = Database.getDalleKeywords(questionId: questionId);

            if (rightDalleAnswer[0].keyword_1 == answer)
            {
                Console.WriteLine("1번 키워드에 대한 정답");
                return true;
            }

            if (rightDalleAnswer[0].keyword_2 == answer)
            {
                Console.WriteLine("2번 키워드에 대한 정답");
                return true;
            }

            if (rightDalleAnswer[0].keyword_3 == answer)
            {
                Console.WriteLine("3번 키워드에 대한 정답");
                return true;
            }

            Console.WriteLine("올바른 키워드가 아닙니다.");
            return false;
        }

        // 9-2 유저의 게임기록을 저장하는 함수
        public static bool recordUserGame(Records records)
        {
            // 기존 기록 있으면 지워야 함
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            MySqlCommand recordQuery = new MySqlCommand(
                "INSERT INTO Records VALUES (@userId, @tryCount, @correctCount, @failCount, @percent)", mysql);

            try
            {
                // 동일한 userId 있을 시 지우고 시작
                MySqlCommand deleteCmd = new MySqlCommand(
                    "DELETE FROM Records WHERE Records.userId = @userId", mysql);
                deleteCmd.Parameters.AddWithValue("@userId", records.userId);
                deleteCmd.ExecuteNonQuery();

                recordQuery.Parameters.AddWithValue("@userId", records.userId);
                recordQuery.Parameters.AddWithValue("@tryCount", records.tryCount);
                recordQuery.Parameters.AddWithValue("@correctCount", records.correctCount);
                recordQuery.Parameters.AddWithValue("@failCount", records.failCount);
                recordQuery.Parameters.AddWithValue("@percent", null);


                Console.WriteLine("게임기록 저장 성공");
                recordQuery.ExecuteNonQuery();

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("게임기록 저장 실패: " + ex.Message);

                return false;
            }
        }
        */

    }
}




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
       
        public static string _server = "localhost";
        public static int _port = 3306;
        public static string _database = "test18";
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


        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
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
                cmd.Parameters.AddWithValue("@ready", false);
                cmd.Parameters.AddWithValue("@Tier", "Bronze");
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

        // 2-1. 로그인하는 함수
        public static User login(string userId, string password)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Users WHERE userId = '{userId}'";

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

                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("로그인 실패" + ex);
                // userId 혹은 password 미일치
                return null;
            }
        }

        // 2-2. 내 기록 가져오기
        public static User getRecords(string userId)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT userId, SUM(tryCount) as tryCount, SUM(correctCount) as correctCount FROM Records WHERE userId = '{userId}'";

            User user = null;

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        user = (new User(
                                    rdr.GetString("userId"),
                                    rdr.GetInt32("tryCount"),
                                    rdr.GetInt32("correctCount")));
                        return user;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("본인기록 가져오기 실패" + ex);
                // userId 혹은 password 미일치
                return null;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

        // 3. 방리스트 가져오는 함수
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
                        if (rdr.GetInt32("Round") != 0)
                        {
                            rooms.Add(new Room(
                                        rdr.GetString("roomId"),
                                        rdr.GetString("userId"),
                                        rdr.GetBoolean("nowPlaying"),
                                        rdr.GetInt32("currentNum"),
                                        rdr.GetInt32("totalNum"),
                                        rdr.GetInt32("level"),
                                        rdr.GetInt32("Round")));
                        }
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

        // 4. 방 
        public static bool makeNewRoom(string roomId, string userId, int totalNum, int level)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Rooms VALUES (@roomId, @userId, @nowPlaying, @currentNum, @totalNum, @level, @Round)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@nowPlaying", 0);
                cmd.Parameters.AddWithValue("@currentNum", 0);
                cmd.Parameters.AddWithValue("@totalNum", totalNum);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.Parameters.AddWithValue("@Round", 1);
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("방 만들기 실패" + ex);
                return false;
            }
        }

        // 6. 방 진입 시도, room타입 반환
        public static Room EnterOrExit_Room(string roomId, string userId, int InOut)
        {
            int currentNum = getSpecificRooms(roomId).currentNum;
            string query = $"UPDATE Rooms SET currentNum = {currentNum + InOut} WHERE roomId = '{roomId}'";

            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            if (InOut == 1)
            {
                if (checkEnterRoom(roomId) == true)
                {
                    try
                    {
                        using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                        {
                            rdr.Close();
                            MapRoom(roomId, userId);
                            Room _room = getSpecificRooms(roomId);
                            return _room;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("방 진입하기 실패" + ex);
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("인원이 다 차서 들어올 수 없음");
                    return null;
                }
            }
            else
            {
                try
                {
                    using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                    {
                        rdr.Close();
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        // 5. 방 진입가능한지 확인
        public static bool checkEnterRoom(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT totalNum - currentNum AS canEnterRoom FROM Rooms WHERE roomId = '{roomId}'";

            using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
            {

                if (rdr.Read() && rdr.GetInt32("canEnterRoom") > 0)
                {
                    return true;
                }

                return false;
            }
        }

        // 6. 방 정보 가져오는 함수 - room 타입 반환
        public static Room getSpecificRooms(string roomId)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Rooms WHERE roomId = '{roomId}'";

            Room _room = null;

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        _room = (new Room(
                                    rdr.GetString("roomId"),
                                    rdr.GetString("userId"),
                                    rdr.GetBoolean("nowPlaying"),
                                    rdr.GetInt32("currentNum"),
                                    rdr.GetInt32("totalNum"),
                                    rdr.GetInt32("level"),
                                    rdr.GetInt32("Round")));
                    }
                }
                Console.WriteLine("특정 방 가져오기 성공");
                return _room;
            }
            catch (Exception ex)
            {
                Console.WriteLine("방 리스트 가져오기 실패" + ex);
                return null;
            }
        }

        // User 테이블에 해당 유저 room 매핑
        public static bool MapRoom(string roomId, string userId)
        {

            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query;
            if (roomId != null)
            {

                query = $"UPDATE Users SET roomId = '{roomId}' WHERE userId = '{userId}'";
            }
            else
            {
                query = $"UPDATE Users SET roomId = NULL WHERE userId = '{userId}'";
            }

            
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("성공12");
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool InableRoom(string roomId)
        {

            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"UPDATE Rooms SET Round = 0 WHERE roomId = '{roomId}'";
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    Console.WriteLine("방 무효화");
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

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
                    return true;
                }
            }
            catch (Exception ex)
            {
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

            string query = $"UPDATE Users SET ready = false WHERE userId = '{userId}'";
            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // 7-2. 해당 방 참가자의 전체 레디 확인
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
                        if (rdr.GetInt32("ready") != 1)
                        { 
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

        // 7-3 특정 유저가 레디했는지 확인

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
                        if (rdr.GetInt32("ready") != 1)
                        {
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

        // 7-4. 전체 유저리스트 가져오기
        public static List<User> getReadyList(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"SELECT userId, ready FROM Users WHERE roomId  = '{roomId}'";

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

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

        // 8-1. 게임 실행 표시, 다른 사람이 못 들어오기 위함.
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

        // 8-2. nowPlaying이 true면 true를 반환
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

        // 8-3. 게임 실행하게 되면 레코드 테이블에 유저 등록
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

        // 해당 방에 이미 등록된 경우(리방인 경우) 체크
        public static bool registerRecordCheck(string userId, string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"SELECT userId FROM Records WHERE roomId = '{roomId}' && WHERE userId = '{userId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        if (rdr.GetString("userId") == userId)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

        // 9. 문제 만드는 함수
        public static bool makeQuestion(string roomId, int QId, string imageUrl, List<string> keyword, int level)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Dalle VALUES (@roomId, @QId, @imageUrl, @keyword_1, @keyword_2, @keyword_3, @keyword_4, @keyword_5, @keyword_6)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.Parameters.AddWithValue("@QId", QId);
                cmd.Parameters.AddWithValue("@imageUrl", imageUrl);

                cmd.Parameters.AddWithValue("@keyword_1", keyword[0]);
                cmd.Parameters.AddWithValue("@keyword_2", keyword[1]);
                cmd.Parameters.AddWithValue("@keyword_3", keyword[2]);
                cmd.Parameters.AddWithValue("@keyword_4", keyword[3]);
                cmd.Parameters.AddWithValue("@keyword_5", keyword[4]);
                cmd.Parameters.AddWithValue("@keyword_6", keyword[5]);

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

        public static bool CheckQuestion(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"SELECT QId FROM Dalle WHERE roomId = '{roomId}' && QId = 5";
            int _QId = 0;

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                   
                    while (rdr.Read())
                    {
                        _QId = rdr.GetInt32("QId");
                    }
                }

                if(_QId == 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }  
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static string getQuestion(string roomId, int round)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT imageUrl FROM Dalle WHERE roomId = '{roomId}' && QId = {round}";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        return rdr.GetString("imageUrl");
                    }
                }
                return null;

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        // 10. 정답 확인
        public static int checkAnswer(string userId, string roomId, int round, string userAnswer)
        {

            int idx = 1;
            int check = 0;

            Dalle dalle = getKeyword(roomId, round);

            foreach (string _keyword in dalle.keywords)
            {
                if (userAnswer == _keyword)
                {
                    check = checkKeyword(roomId, round, idx);
                   
                }
                idx++;
            }

            if (check != 0)  // 새로 + 맞춘 경우
            {


                updateTryCount(userId, roomId);
                updateCorrectCount(userId, roomId);
                Program.AnsList_note[check] = 1;
            }
            else if (check != 0) // 이미 맞춘 경우
            {
                check = 0;
            }
            else  // 못맞춘 경우
            {
                updateTryCount(userId, roomId);
            }
            return check;
            
        }


        // tryCount 업데이트 하는 함수
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

        // correctCount 업데이트 하는 함수
        public static bool updateCorrectCount(string userId, string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            int correctCount = getCorrectCount(userId, roomId) + 1;
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

        public static int updateRound(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            int correctRound = getRound(roomId) + 1;
            string query = $"UPDATE Rooms SET Round = {correctRound} WHERE roomId = '{roomId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    return correctRound;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        public static int getRound(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
                mysql.Open();
            
            string query = $"SELECT Round FROM Rooms WHERE roomId = '{roomId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        return rdr.GetInt32("Round");
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }

        public static bool initRound(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
          
            string query = $"UPDATE Rooms SET Round = 1 WHERE roomId = '{roomId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        // user의 tryCount 가져오기
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

        // user의 correctCount 가져오기
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
                return 0;
            }
            return 0;
        }

        // 달리 키워드 가져오기
        public static Dalle getKeyword(string roomId, int QId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Dalle WHERE roomId = '{roomId}' && QId = {QId}";

            Dalle dalle = null;
            List<string> _keywords = new List<string>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        _keywords.Add(rdr.GetString("keyword_1"));
                        _keywords.Add(rdr.GetString("keyword_2"));
                        _keywords.Add(rdr.GetString("keyword_3"));
                        _keywords.Add(rdr.GetString("keyword_4"));
                        _keywords.Add(rdr.GetString("keyword_5"));
                        _keywords.Add(rdr.GetString("keyword_6"));

                        dalle = (new Dalle(
                                    rdr.GetInt32("QId"),
                                    rdr.GetString("imageUrl"),
                                    _keywords));
                        return dalle;
                    }
                    
                }
                return dalle;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int checkKeyword(string roomId, int round, int idx)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string keyword = "keyword_" + idx.ToString();
            string query = $"UPDATE Dalle SET {keyword} = 'CHECK' WHERE roomId = '{roomId}' && QId = {round}";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    return idx;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////

        // 12. 게임종료 후 결과 확인
        public static List<Records> getRecordEveryone(string roomId)
        {
            // 로그인 유저 있으면 true 없으면 false
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            string query = $"SELECT * FROM Records WHERE roomId = '{roomId}'";

            List<Records> records = new List<Records>();

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        records.Add(new Records(
                                    rdr.GetString("userId"),
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

        public static bool initNowPlaying(string roomId)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }

            string query = $"UPDATE Rooms SET nowPlaying = false WHERE roomId = '{roomId}'";

            try
            {
                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }


    }
}




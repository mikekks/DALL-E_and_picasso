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
using Server.Classes.Instances;
using DalleLib;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;

namespace Server.Classes
{
    static class Database
    {

        public static string _server = "localhost";
        public static int _port = 3306;
        public static string _database = "test1251";
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
            catch (Exception exc)
            {
                Console.WriteLine("DB연결 실패");
                return true;
            }
        }

        // 함수의 Return 타입으로 나오는 Users와 윈폼의 Users 인스턴스가 다름. 
        // 테이블 조합 결과 담은 인스턴스를 조합하여 윈폼 인스턴스에 대입하는 법
        // 테이블을 윈폼 인스턴스에 맞게 재구성하는 법
        // 윈폼 인스턴스를 테이블에 맞게 재구성하는 법

        // 1. 로그인 하는 함수 
        public static List<Users> login(string userId, string password)
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

        // 2. 회원가입하는 함수
        public static bool signUp(Users users)
        {
            if (mysql.State != ConnectionState.Open)
            {
                mysql.Open();
            }
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Users VALUES (@userId, @password, @email, @answer)", mysql);

            try
            {
                cmd.Parameters.AddWithValue("@userId", users.userId);
                cmd.Parameters.AddWithValue("@password", users.password);
                cmd.Parameters.AddWithValue("@email", users.email);
                cmd.Parameters.AddWithValue("@answer", users.answer);

                Console.WriteLine("회원가입 성공");
                cmd.ExecuteNonQuery();

                return true;

            }
            catch
            {
                Console.WriteLine("회원가입 실패");
                // 동일한 userId 존재합니다. (PK)
                return false;
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
                /*
                MySqlCommand deleteCmd = new MySqlCommand(
                    "DELETE FROM Records WHERE Records.userId = @userId", mysql);
                deleteCmd.Parameters.AddWithValue("@userId", userId);
                deleteCmd.ExecuteNonQuery();
                */

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

    }
}




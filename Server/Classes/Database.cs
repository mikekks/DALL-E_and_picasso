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
                return null;
            }
        }
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
                return false;
            }
        }


    }
}




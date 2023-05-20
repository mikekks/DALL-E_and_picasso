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

        public static List<Users> connectDB()
        {
            Console.WriteLine("접근 중");

                mysql.Open();

                string query = $"SELECT * FROM Users";

                List<Users> users = new List<Users>();

                using (MySqlDataReader rdr = new MySqlCommand(query, mysql).ExecuteReader())
                {
                Console.WriteLine("add");

                while (rdr.Read())
                {
                    users.Add(new Users(
                                rdr.GetString("userId"),
                                rdr.GetString("password"),
                                rdr.GetString("email"),
                                rdr.GetString("answer")));
                    }
                }

            Console.WriteLine(users[0].userId);
                return users;

        }

        public static Boolean loginDB(string userId, string password)
        { // 로그인 유저 있으면 true 없으면 false

            string query = string.Format("SELECT password FROM Users WHRER Users.userId = {0}",userId); // userId가 test인 
//            string query = string.Format("SELECT  FROM {0}", tableName);

            MySqlCommand command = new MySqlCommand(query, mysql);


            return false;

        }

    }
}




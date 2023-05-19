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



namespace Server.Classes
{
    static class Database
    {

        public static string _server = "localhost";
        public static int _port = 3306;
        public static string _database = "test1236";
        public static string _id = "root";
        public static string _pw = "00000000";
        public static string _connectionAddress = "";

        public static MySqlConnection mysql = new MySqlConnection(string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw));

        public static Boolean connectDB()
        {
            Console.WriteLine("접근 중");


            try
            {

                mysql.Open();
                    // string selectQuery = string.Format("SELECT * from Users");
                    // MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    // MySqlDataReader table = command.ExecuteReader();


                string query = string.Format("SELECT password FROM Users"); // userId가 test인 
                MySqlCommand command = new MySqlCommand(query, mysql);
                MySqlDataReader table = command.ExecuteReader();


                while (table.Read())
                {
                    Console.WriteLine("1");

                    Console.WriteLine(table["password"]);
                }

                table.Close();
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("실패");
                return false;
            }

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




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

        public static void connectDB()
        {
            Console.WriteLine("접근 중");

            string _server = "localhost";
            int _port = 3306;
            string _database = "kwubuild";
            string _id = "root";
            string _pw = "00000000";
            string _connectionAddress = "";

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * from Users");
                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("성공");

                        /*
                        ID.Text = table["userId"].ToString();
                        TryCount.Text = table["try"].ToString();
                        Ans.Text = table["correct"].ToString();
                        AnsRate.Text = table["percent"].ToString();
                        */
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("실패");
            }

        }
    }
}




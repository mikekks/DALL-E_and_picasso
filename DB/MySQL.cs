using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace mysql
{
    public class connectDB
    {


        public static void connectDB()
        {
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
                    string selectQuery = string.Format("SELECT * FROM room");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {

                        Console.WriteLine(string.Format("Test"))
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("½ÇÆÐ");

                MessageBox.Show(exc.Message);
            }

        }
    }
}

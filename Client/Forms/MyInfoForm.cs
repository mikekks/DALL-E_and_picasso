using DalleLib;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client.Forms
{
    public partial class MyInfoForm : MetroFramework.Forms.MetroForm
    {
        public MyInfoForm()
        {
            InitializeComponent();
        }

        private void MyInfoForm_Load(object sender, EventArgs e)
        {

            Program.user = new User(123,"123");
            Program.user.Tier = "Gold";
            ID.Text = Program.user.userId.ToString();
            TryCount.Text = Program.user.TryCount.ToString();
            Ans.Text = Program.user.AnsCount.ToString();
            AnsRate.Text = Program.user.AnsRate.ToString();

            connectDB();

            string tier = Program.user.Tier;
            if(tier == "Bronze")
            {

            }
            else if (tier == "Sliver")
            {

            }
            else if (tier == "Gold")
            {
                Tier.Image = global::Client.Properties.Resources.Tier_Gold;
            }

        }

        public void connectDB()
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
                    string selectQuery = string.Format("SELECT user.userId, game.try, game.correct,  game.correct / game.try * 100 as percent FROM game, user WHERE game.userId = user.userId");
                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();


                    while (table.Read())
                    {
                        ID.Text = table["userId"].ToString();
                        TryCount.Text = table["try"].ToString();
                        Ans.Text = table["correct"].ToString();
                        AnsRate.Text = table["percent"].ToString();
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("실패");

                MessageBox.Show(exc.Message);
            }

        }
    }
}

using Client.Forms;
using DalleLib.InGame;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
       

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)  // 여러 방들을 여기서 불러와야 함
        {

            // 로그인 하는 과정
            //Hide();


            Program.t_Recieve.Start();
            


            // 방 리스트 불러오기


            // 내 간단 정보 불러오기
            Room1.Text = "                     ";
            Room1.Text += "너만오면 고";
            Room1.Text += "       | 참여인원 3/3 ";

            Room2.Text = "                     ";
            Room2.Text += "고수만       ";
            Room2.Text += "       | 참여인원 2/3 ";

            Room3.Text = "                     ";
            Room3.Text += "아무나오세요";
            Room3.Text += "       | 참여인원 1/3 ";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
            //Hide();
            MyInfoForm myInfoForm = new MyInfoForm();
            myInfoForm.ShowDialog();
            Opacity = 100;
        }

        private void Room1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(Owner, "참여인원이 다 찼습니다");
        }

        private void Room2_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
            InGame inGame = new InGame();
            inGame.ShowDialog();
            Opacity = 1;
        }

        private void btn_Myinfo_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
            //Hide();
            MyInfoForm myInfoForm = new MyInfoForm();
            myInfoForm.ShowDialog();
            Opacity = 100;
        }

        private void btn_CreateRoom_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
            CreateRoomForm createRoomForm = new CreateRoomForm();
            createRoomForm.ShowDialog();

            InGame inGame = new InGame();
            inGame.ShowDialog();
            Opacity = 1;
            
            // 수정해보기
        }
    }
}

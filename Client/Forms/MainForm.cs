using Client.Forms;
using DalleLib.InGame;
using DalleLib.Networks;
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
using System.Threading;
using System.Net.Sockets;
using MetroFramework.Controls;
using DalleLib;
using WindowsFormsApp2;

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
            Hide();

            Login_Form loginForm = new Login_Form();
            loginForm.ShowDialog();
            

            // 로그인 후 정보 갱신 필요.
            //
            //

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

        public void forTest_Connect()
        {
            if (!Program.clientSocket.Connected)
            {
                Program.clientSocket.Connect("127.0.0.1", Program.port);
                Program.stream = Program.clientSocket.GetStream();
                Program.t_Recieve.Start();
            }
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
            // 로딩창 구현 필요
            /*
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Func = (() =>
            {
                Console.WriteLine("TEST!!");
            });
            loadingForm.ShowDialog();
            */
            
            forTest_Connect();

            // 해당 방에 들어갈 수 있는지 패킷을 보내야 함

            // int roomID, int level, string roomName, int PartyNum, int ReadyNum
            
            RoomPacket roomPacket = new RoomPacket(Program.roomList[1], RoomType.Enter);

            Program.MethodList.Add(PacketType.Room, R_EnterRoom);
            Program.Send(roomPacket);
        }

        public void R_EnterRoom(Packet packet)
        {
            RoomPacket roomPacket = packet as RoomPacket;

            if (roomPacket.roomType == RoomType.New)  // 새로운 방 만들기 요청 후 받은 패킷
            {

            }
            else if (roomPacket.roomType == RoomType.Enter)
            {

                // 해당 방에 내가 추가 되었는지 확인하고, 추가 되었으면 방 들어가기 성공
                foreach (User user in roomPacket.room.userList)
                {
                    if (user.userId == Program.user.userId)
                    {
                        
                        
                        if (InvokeRequired)
                        {
                            this.Invoke(new Action(() => { R_EnterRoom(packet); }));
                        }
                        else
                        {
                            Program.room = roomPacket.room;  // 현재 들어가 있는 방을 의미
                            string enter = Program.room.roomName + " 에 들어갑니다.";
                            MetroMessageBox.Show(Owner, enter);
                            //Opacity = 0.5;
                            GameRoom inGame = new GameRoom();
                            Hide();
                            inGame.Show();
                        }
                        
                        
                        
                        break;
                    }
                    
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            forTest_Connect();

            int id = 12345;
            string password = "54321";
            LoginPacket packet = new LoginPacket(id, password);

            Program.MethodList.Add(PacketType.Login, R_Login);

            Program.Send(packet);


        }

        public void R_Login(Packet packet)
        {
            LoginPacket loginPacket = packet as LoginPacket;

            if(loginPacket.success == true)  // 로그인 성공 의미
            {
                Program.user = loginPacket.user;
                Program.roomList = loginPacket.roomList;
                string init = Program.user.username + "님 안녕하세요!";
                MetroMessageBox.Show(Owner, init);

            }
            else  // 로그인 실패 의미
            {

            }
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

            GameRoom inGame = new GameRoom();
            inGame.ShowDialog();
            Opacity = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Func = (() =>
            {
                Thread.Sleep(5000);

                Console.WriteLine("TEST!!");
            });
            loadingForm.ShowDialog();

            /*
            MetroPanel metroPanel = new MetroPanel();
            metroPanel.BringToFront();
            metroPanel.Dock = DockStyle.Fill;
            metroPanel.Parent = this;
            

            MetroProgressSpinner spinner = new MetroProgressSpinner();
            spinner.Location = new System.Drawing.Point(150, 150);
            spinner.Size = new System.Drawing.Size(100, 100);
            spinner.Value = 100;
            spinner.Enabled = true;
            spinner.Maximum = 100;
            spinner.TabIndex = 20;
            spinner.EnsureVisible = true;
            

            spinner.BringToFront();
            spinner.Visible = true;
            
            spinner.Show();
            spinner.Parent = metroPanel;
            */
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

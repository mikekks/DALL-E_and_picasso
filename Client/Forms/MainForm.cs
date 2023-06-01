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
using System.Timers;

namespace Client
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        MetroTile[] roomTile = new MetroTile[1000];
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)  // 여러 방들을 여기서 불러와야 함
        {
            // 로그인 하는 과정
            if (!Program.MethodList.ContainsKey(PacketType.Room))
                Program.MethodList.Add(PacketType.Room, R_EnterRoom);

            if (!Program.MethodList.ContainsKey(PacketType.Setting))
                Program.MethodList.Add(PacketType.Setting, R_Setting);

            Hide();

            if (Program.user == null)
            {
                Login_Form loginForm = new Login_Form();
                loginForm.ShowDialog();

                if (Program.user == null)
                {
                    if (InvokeRequired)
                    {
                        this.Invoke(new Action(() => { this.Close(); }));
                    }

                    
                }
            }


            //MainPic.Load("");

            viewRoomList();

            // 로그인 후 정보 갱신 필요.
            UserId.Text = Program.user.userId;
            UserTier.Text = Program.user.Tier;

            ProfilePic.Image = Properties.Resources.dalle2;

            if(Program.user.Tier == "Bronze")
            {
                TierPic.Image = Properties.Resources.Tier_Bronze;
            }
            else if (Program.user.Tier == "Sliver")
            {
                TierPic.Image = Properties.Resources.Tier_Silver;
            }
            else
            {
                TierPic.Image = Properties.Resources.Tier_Gold;
            }


        }


        public void viewRoomList() // 방 리스트 불러오기
        {

            for(int i=0; i<6; i++)
            {
                metroTabControl1.TabPages[i].Controls.Clear();
            }

            int y = 10;
            for (int i = 0; i < Program.roomList.Count; i++)
            {
                MetroTile _roomTile = new MetroTile();
                _roomTile.Width = 438;
                _roomTile.Height = 65;
                _roomTile.Location = new Point(5, y);
                _roomTile.TileImage = Properties.Resources.Van;
                _roomTile.TileImageAlign = ContentAlignment.MiddleLeft;
                _roomTile.UseTileImage = true;
                y += 70;

                MetroLabel _roomName = new MetroLabel();
                _roomName.Text = Program.roomList[i].roomId;
                _roomName.Location = new Point(105, 20);
                _roomName.Size = new Size(150, 20);
                _roomTile.Controls.Add(_roomName);

                MetroLabel _People = new MetroLabel();
                _People.Text = "현재 인원 : " + Program.roomList[i].currentNum.ToString() + " / " + Program.roomList[i].totalNum.ToString();
                _People.Location = new Point(300, 20);
                _People.Size = new Size(200, 20);
                _roomTile.Controls.Add(_People);

                _roomTile.Click += new EventHandler(Room_Click);
                _roomTile.Tag = Program.roomList[i];
                roomTile[i] = _roomTile;

                int _level = Program.roomList[i].level - 1;

                metroTabControl1.TabPages[_level].Controls.Add(roomTile[i]);
                
            }
        }

        public void R_resetRoomList(Packet packet)
        {
            LoginPacket resetRoomPacket = packet as LoginPacket;

            Program.roomList = resetRoomPacket.roomList;

           
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

        

        public void Room_Click(object sender, EventArgs e)
        {

            forTest_Connect();

            MetroTile btnRoom = sender as MetroTile;
            Room EnterRoom = (Room)btnRoom.Tag;

            // 해당 방에 들어갈 수 있는지 패킷을 보내야 함
            // int roomID, int level, string roomName, int PartyNum, int ReadyNum

            RoomPacket roomPacket = new RoomPacket(EnterRoom, RoomType.Enter);
            roomPacket.user = Program.user;

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
                            string enter = Program.room.roomId + " 에 들어갑니다.";
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

            string id = "12345";
            string password = "54321";
            LoginPacket packet = new LoginPacket(id, password);

            Program.Send(packet);


        }

        /*
        public void R_Login(Packet packet)
        {
            LoginPacket loginPacket = packet as LoginPacket;

            if(loginPacket.success == true)  // 로그인 성공 의미
            {
                Program.roomList = loginPacket.roomList;

                if (loginPacket.reset == false)
                {
                    Program.user = loginPacket.user;
                    string init = Program.user.username + "님 안녕하세요!";
                    MetroMessageBox.Show(Owner, init);
                }

                
                
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { viewRoomList(); }));
                }
                else
                {
                    viewRoomList();
                }
                
            }
            else  // 로그인 실패 의미
            {

            }
        }
        */

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
            Opacity = 1;

            if (Program.room == null)  // 나가기 한 경우
            {
                // ! 업데이트를 시켜줘야 하나?
            }
            else  // 만든 경우
            {

                GameRoom gameRoom = new GameRoom();
                Hide();
                gameRoom.Show();
               
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
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

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void Tab1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            SettingPacket packet = new SettingPacket(Program.user.userId, Program.user.password);
            Program.Send(packet);
        }

        public void R_Setting(Packet packet)
        {
            SettingPacket p = packet as SettingPacket;

            Program.roomList = p.roomList;


            if (InvokeRequired)
            {
                this.Invoke(new Action(() => { R_Setting(packet); }));
            }
            else
            {
                viewRoomList();
            }

        }
    }
}

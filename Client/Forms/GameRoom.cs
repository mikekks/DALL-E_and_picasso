﻿using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using DalleLib.Networks;
using DalleLib.InGame;
using DalleLib;
using MetroFramework;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using MetroFramework.Controls;
using Client.Forms;

namespace Client
{

    public partial class GameRoom : MetroFramework.Forms.MetroForm
    {
        //DataSet2 dataset;

        Font mapleFont = new Font(FontManager.fontFamilys[0], 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        
        Font mapleFont1 = new Font(FontManager.fontFamilys[0], 22, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont1_5 = new Font(FontManager.fontFamilys[0], 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2 = new Font(FontManager.fontFamilys[0], 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2_5 = new Font(FontManager.fontFamilys[0], 13, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        Font mapleFont3 = new Font(FontManager.fontFamilys[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont4 = new Font(FontManager.fontFamilys[0], 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));


        TcpClient clientSocket = new TcpClient();
        public bool Ready = false;
        public bool Start = false;

        public int forTest = 0;


        public MetroTile[] metroTiles = null;
        
        public GameRoom()
        {
            InitializeComponent();
         }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!Program.MethodList.ContainsKey(PacketType.InGame))
                Program.MethodList.Add(PacketType.InGame, R_PlayGame);

            label2.Text += Program.room.roomId;  // 방의 제목
            label2.Font = mapleFont1;
            label1.Font = mapleFont2;
            label3.Font = mapleFont2;
            timeLimit.Font = mapleFont2;
            label4.Font = mapleFont1_5;
            label5.Font = mapleFont1_5;

            ResetReadyList();
            ResetChatList();

            metroTiles = new MetroTile[] { Answer1, Answer2, Answer3, Answer4, Answer5, Answer6 };
            for (int i = 0; i < 6; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.whatMark_removebg_preview;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                metroTiles[i].Controls.Add(pictureBox);
            }

            // 필요한 정답 칸 계산해서 생성
            metroTiles = new MetroTile[] { Answer1, Answer2, Answer3, Answer4, Answer5, Answer6 };
            for (int i=5; i>=Program.room.level; i--)
            {
                metroTiles[i].Enabled = false;

                metroTiles[i].Text = "뭘까요?";
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.xMark_removebg_preview; 
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                metroTiles[i].Controls.Add(pictureBox);
            }
            
        }
        public void ResetReadyList()
        {

            ready_list1.Controls.Clear();
            ready_list2.Controls.Clear();
            int i = 0;
            int y = 0;
            foreach (User player in Program.room.userList)
            {
                Button _button1 = new Button();
                Button _button2 = new Button();
                _button1.Enabled = false;
                _button2.Enabled = false;

                _button1.Size = new Size(134, 42);
                _button1.Text = player.userId;
                _button1.Font = mapleFont2_5;
                _button1.Location = new Point(0, y);


                _button2.Size = new Size(80, 42);
                _button2.Font = mapleFont2_5;
                _button2.Location = new Point(3, y);
                if (player.ready == true)
                {
                    _button2.Text = "Ready!";
                }
                else
                {
                    _button2.Text = "Wait..";
                }

                _button1.ForeColor = Color.MidnightBlue;
                _button2.ForeColor = Color.MidnightBlue;
                if (i % 2 == 1)
                {
                    _button1.BackColor = Color.LemonChiffon;
                    _button2.BackColor = Color.LemonChiffon;
                   
                }
                else
                {
                    _button1.BackColor = Color.LightSkyBlue;
                    _button2.BackColor = Color.LightSkyBlue;
             
                }

                i++;
                y += 50;

                ready_list1.Controls.Add(_button1);
                ready_list2.Controls.Add(_button2);
            }
        }

        public void ResetChatList()
        {
            chat_list.Controls.Clear();

            if (Program.room.ChatList == null)
            {
                return;
            }


            int i = 0;
            int y = 5;
            foreach (Chat chat in Program.room.ChatList)
            {
                Button _button1 = new Button();
                _button1.Enabled = false;

                _button1.Size = new Size(248, 23);
                _button1.Text = chat.sender + " : " + chat.chat;
                _button1.Font = mapleFont4;
                _button1.Location = new Point(0, y);
                _button1.FlatAppearance.BorderSize = 0;
                _button1.FlatStyle = FlatStyle.Flat;
                _button1.TextAlign = ContentAlignment.MiddleLeft;
                if (chat.sender != Program.user.userId)
                {
                    _button1.BackColor = Color.LemonChiffon;
                    _button1.ForeColor = Color.MidnightBlue;
                }
                else
                {
                    _button1.BackColor = Color.LightSkyBlue;
                    _button1.ForeColor = Color.MidnightBlue;
                }

                i++;
                y += 30;
                chat_list.Controls.Add(_button1);
            }
            
        }

        public void R_PlayGame(Packet packet)
        {
            InGamePacket p = packet as InGamePacket;

            if (p.respondType == respondType.Ready)
            {
                Program.room = p.room;

                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_PlayGame(packet); }));
                }
                else
                {
                    ResetReadyList();
                }
   
            }
            else if (p.respondType == respondType.Chat)
            {
                Program.room = p.room;

                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_PlayGame(packet); }));
                }
                else
                {
                    ResetChatList();
                }
            }
            else if (p.respondType == respondType.Loading)
            {
                InitLoadingForm loadingForm = new InitLoadingForm();
                loadingForm.ShowDialog();
            }
            else if(p.respondType == respondType.Start)  // 무조건 게임 시작해도 됨을 의미
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_PlayGame(packet); }));
                }
                else
                {
                    Console.WriteLine("start 패킷 도착");

                    if (!p.IsHost)
                    {
                        MetroMessageBox.Show(Owner, "방장이 아닙니다");
                        return;
                    }

                    if (!p.start)
                    {
                        MetroMessageBox.Show(Owner, "모두 준비되지 않았습니다");
                        return;
                    }

                    Program.room.round = p.room.round;

                    // 로딩 화면
                    LoadingForm loadingForm = new LoadingForm(5);
                    loadingForm.ShowDialog();
                    
                    for (int i = 0; i < Program.room.level; i++)
                    {
                      

                        metroTiles[i].Text = "";

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Properties.Resources.whatMark_removebg_preview;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Dock = DockStyle.Fill;
                        metroTiles[i].Controls.Add(pictureBox);

                        // PictureBox를 MetroTile의 Controls 컬렉션에 추가
                        metroTiles[i].Controls.Add(pictureBox);
                    }

                    Console.WriteLine("start 패킷 도착2");

                    string url = p.room.Question;
                    picBox.Load(url);
                    Start = true;
                    btn_Ready.Enabled = false;

                    GameTimer.Start();
 
                }
            }
            else if (p.respondType == respondType.Answer)
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_PlayGame(packet); }));
                }
                else
                {
                   if(p.correct != 0)  // 정답 맞춘 경우
                    {
                        string tmp = p.user.userId.ToString() + " 가 정답을 맞췄습니다";
                        MetroMessageBox.Show(Owner, tmp);
                        metroTiles[p.correct - 1].Controls.Clear();
                        metroTiles[p.correct - 1].Text = p.Answer;
                        metroTiles[p.correct - 1].Font = mapleFont2_5;
                    }
                    else  // 정답 틀린 경우
                    {
                        MetroMessageBox.Show(Owner, "틀렸습니다");
                    }
                }
            }
            else if (p.respondType == respondType.End)  // 해당 게임 종료를 의미
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_PlayGame(packet); }));
                }
                else
                {
                    Program.records = p.records;

                    GameResultForm gameResultForm = new GameResultForm();
                    gameResultForm.ShowDialog();

                    // 초기화된 방으로 업데이트 필요, (nowplaying 변경, 라운드 초기화)
                    Program.room = p.room;

                    // 내 정보도 업데이트
                    Program.user.TryCount = p.user.TryCount;
                    Program.user.AnsCount = p.user.AnsCount;

                    // 레디 해제 (의미는 없는듯)
                    Program.user.ready = p.user.ready;

                    ResetReadyList();
                    picBox.Image = Properties.Resources.mainImage;
                    btn_Ready.Enabled = true;
                    Ready = false;
                }
            }
            
        }

        private void btn_Ready_Click_1(object sender, EventArgs e)
        {
            if(Ready == true)
            {
                Ready = false;
            }
            else
            {
                Ready = true;
                InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 레디 했는지 안했는지를 전달
                ingamePacket.respondType = respondType.Ready;
                ingamePacket.ready = Ready;
                Program.Send(ingamePacket);
            }
           

           
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);
            ingamePacket.respondType = respondType.Chat;

            Chat chat = new Chat(Program.user.userId, Program.room.roomId, tbAnswer.Text, DateTime.Now);
            ingamePacket.room.ChatList = new List<Chat>() { chat };

            Program.Send(ingamePacket);

            tbAnswer.Text = "";
            tbAnswer.Focus();

        }


        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void GameRoom_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (GameTimer.Enabled)
                GameTimer.Stop();

            // ready 해제 및 room 매핑 해제
            RoomPacket roomPacket = new RoomPacket(Program.room, RoomType.Exit);
            roomPacket.user = Program.user;

            Program.Send(roomPacket);

            if (clientSocket != null)
                clientSocket.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();

            //System.Windows.Forms.Application.Exit();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
           
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            int curTime = int.Parse(timeLimit.Text);
            if(curTime > 0)
            {
                curTime--;
                timeLimit.Text = curTime.ToString();
            }
            else
            {
                GameTimer.Enabled = false;
                Start = false;  // 로딩창 다시 띄우기 위해서

                timeLimit.Text = "10";

                // 현재 라운드가 종료됨을 서버에게 알림
                InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달

                ingamePacket.Type = PacketType.InGame;
                ingamePacket.respondType = respondType.NextGame;

                Console.WriteLine("다음 라운드 진행");

                // 방장이 다음 문제 요구
                if(Program.room.userId == Program.user.userId)
                    Program.Send(ingamePacket);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void Answer1_Click(object sender, EventArgs e)
        {

        }

        private void Answer4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Answer1_Click_1(object sender, EventArgs e)
        {

        }

        private void Answer3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_AnsSend_Click(object sender, EventArgs e)
        {
            InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달
            ingamePacket.respondType = respondType.Answer;

            ingamePacket.Answer = tbAnswer.Text;

            Program.Send(ingamePacket);

            tbAnswer.Text = "";
            tbAnswer.Focus();
        }

        private void btn_Start_Click_1(object sender, EventArgs e)
        {
            // 모두 레디했는지 확인
            bool CanStart = true;

            foreach (User player in Program.room.userList)
            {

                if (player.ready == false)  // 예외처리
                {
                    CanStart = false;
                    MetroMessageBox.Show(this, "모두 준비가 되지 않았습니다.");
                    return;
                }
            }

            if (CanStart)  // 모두 준비가 돼서 시작 가능
            {
                InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달
                ingamePacket.respondType = respondType.Start;

                ingamePacket.ready = Ready;

                Program.Send(ingamePacket);
            }
        }



        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);
                ingamePacket.respondType = respondType.Chat;

                Chat chat = new Chat(Program.user.userId, Program.room.roomId, tbAnswer.Text, DateTime.Now);
                ingamePacket.room.ChatList = new List<Chat>() { chat };

                Program.Send(ingamePacket);

                tbAnswer.Text = "";
                tbAnswer.Focus();
            }
        }

        private void btn_exit_Click_2(object sender, EventArgs e)
        {
            Close();
        }
    }
}

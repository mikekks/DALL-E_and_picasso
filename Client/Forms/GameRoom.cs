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

namespace Client
{
    public partial class GameRoom : MetroFramework.Forms.MetroForm
    {
        delegate void TimerEventFiredDelegate();

        TcpClient clientSocket = new TcpClient();
        public bool Ready = false;
        public bool Start = false;

        public int forTest = 0;

        System.Timers.Timer timer = new System.Timers.Timer();

        public GameRoom()
        {
            InitializeComponent();
            /*
            new Thread(delegate ()
            {
                InitSocket();
            }).Start();
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 해당 방에 대한 쿼리, 로딩 필요
            
            Text = Program.room.roomName;  // 방의 제목을 의미
            picBox.Load("https://static.designboom.com/wp-content/uploads/2022/06/dalle-2-ai-system-designboom-01.jpg");
            
            // 레디 타이머 설정
            timer.Interval = 2000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            

            // 방 들어가기 전에 Room이 갱신됨
            foreach (User player in Program.room.userList)
            {
                rdy_list.Text += Environment.NewLine + player.username;
            }
            rdy_list.Text += Environment.NewLine + "Lee ju song";


            // 방장인지 확인하고, 방장이면 Start 버튼 활성화
            if (Program.room.Host.userId == Program.user.userId)
            {
                btn_Start.Enabled = true;
            }
            else
            {
                btn_Start.Enabled = false;
            }
        }

        private void InitSocket()
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 9999);  // AcceptTcpClient와 상응
       
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // UI Thread 처리
            BeginInvoke(new TimerEventFiredDelegate(Ready_Check));
        }


        public void Ready_Check()
        {
            if(!Program.MethodList.ContainsKey(PacketType.InGame))
                Program.MethodList.Add(PacketType.InGame, R_PlayGame);

            bool CanStart = true;
            InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달
            ingamePacket.Type = PacketType.InGame;
            foreach (User player in Program.room.userList)
            {

                if (!Program.room.ReadyList[player.userId])  // 모두 준비되지 않음.
                {
                    CanStart = false;
                    //MetroMessageBox.Show(this, "모두 준비가 되지 않았습니다.");
                    Console.WriteLine("Not Yet {0}\n", forTest);
                }
            }

            forTest++;

            if (CanStart || forTest > 2)  // 모두 준비가 돼서 시작 가능, try의 느낌
            {
                ingamePacket.respondType = respondType.Start;
            }
            else  // 모두 준비가 안돼서 시작 불가능
            {
                ingamePacket.respondType = respondType.Ready;
            }
 
            ingamePacket.ready = Ready;
            Program.Send(ingamePacket);
            timer.Close();
            timer.Dispose();
            
        }

        private void btn_Ready_Click(object sender, EventArgs e)
        {
            Ready = true;
            
            if(!Program.MethodList.ContainsKey(PacketType.InGame))
                Program.MethodList.Add(PacketType.InGame, R_PlayGame);

            Thread t_hanlder = new Thread(doReady);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
           
        }

        private void doReady()
        {
            //NetworkStream stream = Program.stream;
            // NetworkStream stream = clientSocket.GetStream();  ! 로그인단에서 구현필요.
            InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 레디 했는지 안했는지를 전달
            ingamePacket.respondType = respondType.Ready;

            ingamePacket.ready = Ready;

            Program.Send(ingamePacket);
 
            /*  서버에 처리하기 전에 그냥 처리해줌
            if (rdy_list.InvokeRequired)
            {
                rdy_list.BeginInvoke(new MethodInvoker(delegate
                {  
                    rdy_list.Clear();  // 수정필요
                    foreach (User player in Program.room.userList)
                    {
                        
                        rdy_list.Text += Environment.NewLine + player.username;
                        if (Ready || Program.room.ReadyList[player.userId] == true)
                        {
                            rdy_list.Text += " : Ready!";
                        }
                    }
                    
                }));
            }
            */
            
        }

        public void R_PlayGame(Packet packet)
        {
            InGamePacket p = packet as InGamePacket;

            if(p.respondType == respondType.Ready)
            {
                Program.room = p.room;
                foreach (User player in Program.room.userList)  // 레디리스트 갱신
                {
                    rdy_list.Clear();
                    rdy_list.Text += Environment.NewLine + player.username;
                    if (p.room.ReadyList[player.userId])
                    {
                        rdy_list.Text += " : Ready!";
                    }
                }
            }
            else if(p.respondType == respondType.Start)  // 무조건 게임 시작해도 됨을 의미
            {
                string url = p.room.Question;
                picBox.Load(url);
                Start = true;
                timer.Stop();   // ! 여기서 타이머 stop한다.
            }
            else if (p.respondType == respondType.Answer)
            {

            }
        }
 

        private void btn_Send_Click(object sender, EventArgs e)
        {
            NetworkStream stream = clientSocket.GetStream();
            byte[] sbuffer = Encoding.Unicode.GetBytes(tbAnswer.Text + "$");  // 여기만 다름
            stream.Write(sbuffer, 0, sbuffer.Length);
            stream.Flush();

            byte[] rbuffer = new byte[1024];
            stream.Read(rbuffer, 0, rbuffer.Length);
            string msg = Encoding.Unicode.GetString(rbuffer);
            msg = "Data from Server : " + msg;
            //DisplayText(msg);

            tbAnswer.Text = "";
            tbAnswer.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSocket != null)
                clientSocket.Close();
        }

        private void DisplayText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new MethodInvoker(delegate
                {
                    richTextBox1.AppendText(Environment.NewLine + " >> " + text);
                }));
            }
            else
                richTextBox1.AppendText(Environment.NewLine + " >> " + text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void rdy_list_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void GameRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            
            MainForm mainForm = new MainForm();
            mainForm.Show();

            System.Windows.Forms.Application.Exit();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // 모두 레디했는지 확인
            bool CanStart = true;

            foreach (User player in Program.room.userList)
            {
                
                if (!Program.room.ReadyList[player.userId])  // 예외처리
                {
                    CanStart = false;
                    MetroMessageBox.Show(this, "모두 준비가 되지 않았습니다.");
                }
            }

            if (CanStart)  // 모두 준비가 돼서 시작 가능
            {
                InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달
                ingamePacket.respondType = respondType.Start;

                ingamePacket.ready = Ready;

                Program.Send(ingamePacket);
            }
            else  // 모두 준비가 안돼서 시작 불가능
            {

            }
        }
    }
}
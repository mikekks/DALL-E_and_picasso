using System;
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
        delegate void TimerEventFiredDelegate();

        TcpClient clientSocket = new TcpClient();
        public bool Ready = false;
        public bool Start = false;

        public int forTest = 0;

        System.Timers.Timer timer = new System.Timers.Timer();

        public MetroTile[] metroTiles = null;
        
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
            
            Text = Program.room.roomId;  // 방의 제목을 의미
           // picBox.Load("https://static.designboom.com/wp-content/uploads/2022/06/dalle-2-ai-system-designboom-01.jpg");
            
            // 레디 타이머 설정
            timer.Interval = 300;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);


            // 방 들어가기 전에 Room이 갱신됨
            ResetReadyList();


             // 필요한 정답 칸 계산해서 생성
             metroTiles = new MetroTile[] { Answer1, Answer2, Answer3, Answer4, Answer5, Answer6 };
            for (int i=5; i>=Program.room.level; i--)
            {
                metroTiles[i].Enabled = false;
                metroTiles[i].Text = "X";
            }


            // 방장인지 확인하고, 방장이면 Start 버튼 활성화
            /*
            if (Program.room.Host.userId == Program.user.userId)
            {
                btn_Start.Enabled = true;
            }
            else
            {
                btn_Start.Enabled = false;
            }
            */
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

                if (player.ready == false)  // 모두 준비되지 않음.
                {
                    CanStart = false;
                }
            }


            if (CanStart)  // 모두 준비가 돼서 시작 가능, try의 느낌
            {
                ingamePacket.respondType = respondType.Start;
            }
            else  // 모두 준비가 안돼서 시작 불가능
            {
                ingamePacket.respondType = respondType.Ready;
            }
 
            ingamePacket.ready = Ready;

            if (timer.Enabled)  // ! 여기서 타이머 stop한다.
                timer.Stop();

            Program.Send(ingamePacket);
            //timer.Close();
            //timer.Dispose();
            
        }

        public void ResetReadyList()
        {
            foreach (User player in Program.room.userList)
            {
                rdy_list.Clear();
                rdy_list.Text += "--------Ready List--------";
                rdy_list.Text += Environment.NewLine + player.userId;
                if (player.ready == true)
                {
                    rdy_list.ForeColor = Color.Red;
                    rdy_list.Text += "     ready!";
                    rdy_list.ForeColor = Color.Black;
                }
            }
        }

        private void btn_Ready_Click(object sender, EventArgs e)
        {
            Ready = true;
            btn_Ready.Enabled = false;

            if (!Program.MethodList.ContainsKey(PacketType.InGame))
                Program.MethodList.Add(PacketType.InGame, R_PlayGame);

            Thread t_hanlder = new Thread(doReady);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
            timer.Start();
        }

        private void doReady()
        {
           
            InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 레디 했는지 안했는지를 전달
            ingamePacket.respondType = respondType.Ready;

            ingamePacket.ready = Ready;

            Program.Send(ingamePacket);
            
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
                    if (!timer.Enabled)  // ! 여기서 타이머 stop한다.
                        timer.Start();
                    ResetReadyList();
                }
   
            }
            else if(p.respondType == respondType.Start)  // 무조건 게임 시작해도 됨을 의미
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_PlayGame(packet); }));
                }
                else
                {
                    // 로딩화면 
                    if (!Start)  // 처음 게임시작에만 띄움
                    {
                        LoadingForm loadingForm = new LoadingForm();
                        loadingForm.ShowDialog();
                    }

                    string url = p.room.Question;
                    picBox.Load(url);
                    Start = true;

                    if(timer.Enabled)  // ! 여기서 타이머 stop한다.
                        timer.Stop();   

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
                        metroTiles[p.correct - 1].Text = p.Answer;
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

                    // 초기화된 방으로 업데이트 필요
                    Program.room = p.room;

                    // 내 정보도 업데이트, 레디 해제
                    InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달
                    ingamePacket.respondType = respondType.End;

                    ingamePacket.Answer = tbAnswer.Text;

                    Program.Send(ingamePacket);


                    Program.user = p.user;
                    btn_Ready.Enabled = true;
                }
            }
            
        }
 

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (!Program.MethodList.ContainsKey(PacketType.InGame))
                Program.MethodList.Add(PacketType.InGame, R_PlayGame);

            InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달
            ingamePacket.respondType = respondType.Answer;

            ingamePacket.ready = Ready;
            ingamePacket.Answer = tbAnswer.Text;

            Program.Send(ingamePacket);

            tbAnswer.Text = "";
            tbAnswer.Focus();
        }

        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ready 풀기?
            RoomPacket roomPacket = new RoomPacket(Program.room, RoomType.Exit);
            
            Program.Send(roomPacket);

            if (clientSocket != null)
                clientSocket.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void rdy_list_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            
            MainForm mainForm = new MainForm();
            mainForm.Show();

            //System.Windows.Forms.Application.Exit();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // 모두 레디했는지 확인
            bool CanStart = true;

            foreach (User player in Program.room.userList)
            {
                
                if (player.ready == false)  // 예외처리
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
                // 게임이 종료됨을 서버에게 알림
                InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);  // 누가, 어디방에서, 시작하려고 하는지 데이터 전달

                ingamePacket.Type = PacketType.InGame;
                ingamePacket.respondType = respondType.NextGame;
                Program.Send(ingamePacket);
            }
        }
    }
}

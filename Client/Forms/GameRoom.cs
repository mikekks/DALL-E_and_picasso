using System;
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

namespace Client
{
    public partial class GameRoom : MetroFramework.Forms.MetroForm
    {
        TcpClient clientSocket = new TcpClient();
        public bool Ready = false;
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


            // 방 들어가기 전에 Room이 갱신됨
            foreach(User player in Program.room.userList)
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

        private void btn_Ready_Click(object sender, EventArgs e)
        {
            Ready = true;
            Program.MethodList.Add(PacketType.InGame, R_PlayGame);

            Thread t_hanlder = new Thread(doReady);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
        }

        private void doReady()
        {
            //NetworkStream stream = Program.stream;
            // NetworkStream stream = clientSocket.GetStream();  ! 로그인단에서 구현필요.
            InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);
            ingamePacket.respondType = respondType.Ready;
            Program.Send(ingamePacket);
 

            if (rdy_list.InvokeRequired)
            {
                rdy_list.BeginInvoke(new MethodInvoker(delegate
                {
                    rdy_list.Clear();
                    foreach (User player in Program.room.userList)
                    {
                        
                        rdy_list.Text += Environment.NewLine + player.username;
                        if (Ready)
                        {
                            rdy_list.Text += " : Ready!";
                        }
                    }
                    rdy_list.Text += Environment.NewLine + "Lee ju song";
                }));
            }
            
        }

        public void R_PlayGame(Packet packet)
        {
            InGamePacket p = packet as InGamePacket;

            if(p.respondType == respondType.Ready)
            {
                foreach (User player in Program.room.userList)
                {
                    rdy_list.Text += Environment.NewLine + player.username;
                    if (p.room.ReadyList[player.userId])
                    {
                        rdy_list.Text += " : Ready!";
                    }
                }
            }
            else if(p.respondType == respondType.Answer)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Ready == true)
            {
                //NetworkStream stream = Program.stream;
                InGamePacket ingamePacket = new InGamePacket(Program.user, Program.room);
                ingamePacket.respondType = respondType.Ready;
                Program.Send(ingamePacket);
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
            new Thread(delegate ()  // 테스트용
            {
                InitSocket();
            }).Start();
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
    }
}

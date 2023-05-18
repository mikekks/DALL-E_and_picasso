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

namespace Client
{
    public partial class InGame : MetroFramework.Forms.MetroForm
    {
        TcpClient clientSocket = new TcpClient();
        public InGame()
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
            Text = "고수만";  // 방의 제목을 의미
            
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

       

        private void btnReady_Click(object sender, EventArgs e)
        {
            Thread t_hanlder = new Thread(doReady);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();

           // richTextBox1.AppendText(Environment.NewLine + " >> " + Program.user.username);
        }

        private void doReady()
        {
            NetworkStream stream = Program.stream;
            // NetworkStream stream = clientSocket.GetStream();  ! 로그인단에서 구현필요.
            ReadyPacket readyPacket = new ReadyPacket(Program.user, Program.room);
            Program.Send(readyPacket);


            
            /*
            if (picBox.InvokeRequired)
            {
                picBox.BeginInvoke(new MethodInvoker(delegate
                {
                    picBox.Load(msg);
                    tbAnswer.Text = "";
                    tbAnswer.Focus();
                }));
            }
            */
        }

        private void btnSend_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void btn_Ready_Click(object sender, EventArgs e)
        {
            Ready = true;

            Thread t_hanlder = new Thread(doReady);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
        }
    }
}

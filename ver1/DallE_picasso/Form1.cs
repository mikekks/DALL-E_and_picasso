using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DallE_picasso
{
    public partial class Form1 : Form
    {
        TcpListener server = null;
        TcpClient client = null;
        static int counter = 0;

        public Form1()
        {
            InitializeComponent();
            // socket start
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client_list.View = View.Details;

            client_list.Columns.Add("ID", "ID                           ");
            client_list.Columns.Add("Point", "Point      ");
            client_list.Columns.Add("Rank", "Rank       ");
            client_list.Columns.Add("last", "last");

            client_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            client_list.Columns.RemoveByKey("last");

            client_list.Columns[0].TextAlign = HorizontalAlignment.Left;
            client_list.Columns["Point"].TextAlign = HorizontalAlignment.Center;
            client_list.Columns[2].TextAlign = HorizontalAlignment.Right;

        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any, 9999);  // 서버에서 9999포트 열어둠
            client = default(TcpClient);
            int option;

            


            server.Start();  // 9999포트 열어둔 쓰레드 시작
            DisplayText(">> Server Started");

            while (true)
            {
                try
                {
                    counter++;
                    client = server.AcceptTcpClient();  // 클라이언트 연결 대기
                    DisplayText(">> Accept connection from client");

                    handleClient h_client = new handleClient();  // 클라이언트 인스턴스 생성
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(DisplayText);  // 이벤트 등록
                    h_client.OnCalculated += new handleClient.CalculateClientCounter(CalculateCounter);  // 이벤트 등록
                    h_client.startClient(client, counter);  // 이 동작을 통해 클라이언트 쓰레드가 만들어짐
                }
                catch (SocketException se)
                {
                    Trace.WriteLine(string.Format("InitSocket - SocketException : {0}", se.Message));
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(string.Format("InitSocket - Exception : {0}", ex.Message));
                }
            }
        }

        private void CalculateCounter()
        {
            counter--;
        }

        private void DisplayText(string text)
        {
            if (client_log.InvokeRequired)   // UI 스레드가 아닌 작업 스레드가 접근할 경우
            {
                client_log.BeginInvoke(new MethodInvoker(delegate  // BeginInvoke 메소드를 사용하여 UI 스레드로 작업 요청을 보낸다.
                {
                    client_log.AppendText(text + Environment.NewLine);
                }));
            }
            else
                client_log.AppendText(text + Environment.NewLine);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }

            if (server != null)
            {
                server.Stop();
                server = null;
            }
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

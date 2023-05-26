using Client;
using DalleLib.Networks;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login_Form : Form
    {
        public delegate void EndForm();

        public Login_Form()
        {
            InitializeComponent();
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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            DialogResult Result = register_Form.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string pw = txt_PW.Text;


            forTest_Connect();
            
            LoginPacket packet = new LoginPacket(id, pw);

            if(!Program.MethodList.ContainsKey(PacketType.Login))
                Program.MethodList.Add(PacketType.Login, R_Login);

            Program.Send(packet);

        }

        public void R_Login(Packet packet)
        {
            LoginPacket loginPacket = packet as LoginPacket;

            if (loginPacket.success == true)  // 로그인 성공 의미
            {
                Program.user = loginPacket.user;
                Program.roomList = loginPacket.roomList;
                string init = Program.user.userId + "님 안녕하세요!";
                MessageBox.Show(this.Parent, init);
                this.Invoke(new EndForm(tmp));
            }
            else  // 로그인 실패 의미
            {

            }
        }
        
        public void tmp()
        {
            Close();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            // 아이디, 비밀번호 찾는 버튼, 이후 폼 따로 추가 예정
        }




        // 이 아래는 UI 디자인 하는데 필요한 요소들!

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
       {
            txt_PW.UseSystemPasswordChar = false;
       }

       private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
       {
            txt_PW.UseSystemPasswordChar = true;
       }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

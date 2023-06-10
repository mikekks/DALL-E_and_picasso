using DalleLib.Networks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using WindowsFormsApp2;
using DalleLib.InGame;

namespace Client.Forms
{
    public partial class FindMyInfo : MetroFramework.Forms.MetroForm
    {
        public MetroTextBox[] tb;

        public FindMyInfo()
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

        private void FindMyInfo_Load(object sender, EventArgs e)
        {
            forTest_Connect();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (!Program.MethodList.ContainsKey(PacketType.Register))
                Program.MethodList.Add(PacketType.Register, R_Register);

            var identificationNumberHash = SHA256Helper.ComputeSHA256Hash(findId_tb_identificationNumber.Text);

            RegisterPacket registerPacket = new RegisterPacket(findId_tb_name.Text, identificationNumberHash, findId_tb_recovery_Q.Text, findId_tb_recovery_A.Text);
            registerPacket.Type = PacketType.Register;
            registerPacket.registerType = RegisterType.findId;
            Program.Send(registerPacket);
        }

        public void R_Register(Packet packet)
        {
            RegisterPacket p = packet as RegisterPacket;

            if (p.registerType == RegisterType.findId)  // 아이디 찾은 경우
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_Register(packet); }));
                }
                else
                {
                    if (p.findId != null)
                    {
                        MetroMessageBox.Show(Owner, string.Format("귀하의 아이디는 {0} 입니다.", p.id));
                    }
                    else
                    {
                        MetroMessageBox.Show(Owner, "일치하는 아이디가 없습니다.");
                    }
                    this.Close();
                }
            }
            else if (p.registerType == RegisterType.findPassword)  // 비밀번호 찾은 경우
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_Register(packet); }));
                }
                else
                {
                    if (p.findPassword != null)
                    {
                        MetroMessageBox.Show(Owner, string.Format("귀하의 비밀번호는 {0} 입니다.", p.password));
                        Console.WriteLine(p.password);
                    }
                    else
                    {
                        MetroMessageBox.Show(Owner, "비밀번호 찾기 실패");
                    }
                    this.Close();
                }
            }
        }

        private void tb_pwd_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Program.MethodList.ContainsKey(PacketType.Register))
                Program.MethodList.Add(PacketType.Register, R_Register);

            var identificationNumberHash = SHA256Helper.ComputeSHA256Hash(findPw_tb_identificationNumber.Text);

            RegisterPacket registerPacket = new RegisterPacket(findPw_tb_name.Text, findPw_tb_id.Text, identificationNumberHash, findPw_tb_recovery_Q.Text, findPw_tb_recovery_A.Text);
            registerPacket.Type = PacketType.Register;
            registerPacket.registerType = RegisterType.findPassword;
            Program.Send(registerPacket);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

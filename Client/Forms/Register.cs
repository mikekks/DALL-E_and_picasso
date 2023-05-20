using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using DalleLib.InGame;
using DalleLib.Networks;
using MetroFramework;
using MetroFramework.Controls;

namespace WindowsFormsApp2
{
    public partial class Register_Form : MetroFramework.Forms.MetroForm
    {
        public bool duplicateCheck;
        public MetroTextBox[] tb;

        public Register_Form()
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

        private void btn_IDcheck_Click(object sender, EventArgs e)
        {
            // id 중복도 검사
            if(!Program.MethodList.ContainsKey(PacketType.Register))
                Program.MethodList.Add(PacketType.Register, R_Register);

            RegisterPacket registerPacket = new RegisterPacket(tb_id.Text);
            registerPacket.Type = PacketType.Register;
            registerPacket.registerType = RegisterType.duplicate;
            Program.Send(registerPacket);

        }

        public void R_Register(Packet packet)
        {
            RegisterPacket p = packet as RegisterPacket;

            if(p.registerType == RegisterType.duplicate)  // 중복도 검사의 경우
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_Register(packet); }));
                }
                else
                {
                    if (p.duplicate == true)
                    {
                        duplicateCheck = true;
                        MetroMessageBox.Show(Owner, "중복검사 통과");
                    }
                    else
                    {
                        duplicateCheck = false;
                        MetroMessageBox.Show(Owner, "중복된 아이디가 있습니다");
                    }
                }
            }
            else if(p.registerType == RegisterType.create)  // 회원가입한 경우
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_Register(packet); }));
                }
                else
                {
                    if (p.regiser_Success == true)
                    {
                        MetroMessageBox.Show(Owner, "회원가입에 성공했습니다.");
                    }
                    else
                    {
                        MetroMessageBox.Show(Owner, "회원가입 실패");
                    }
                    this.Close();
                }
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            // 비밀번호 확인
            if(tb_pwd.Text != tb_pwd_Check.Text)
            {
                MetroMessageBox.Show(Owner, "비밀번호가 서로 다릅니다.");
                return;
            }

            tb = new MetroTextBox[] { tb_id, tb_pwd, tb_pwd_Check, tb_nickName, tb_recovery_A };
            foreach(MetroTextBox _tb in tb)
            {
                if (string.IsNullOrWhiteSpace(_tb.Text))
                {
                    _tb.Focus();
                    prompt.ForeColor = Color.Red;
                    prompt.Text = $"{_tb.WaterMark}를 입력해주세요.";
                }
            }

            if (recovery_Q.SelectedIndex == -1)
                recovery_Q.SelectedIndex = 0;

            // db에 해당 정보 저장 -> 성공 했는지 안했는지 결과 출력 필요

            RegisterPacket registerPacket =
                new RegisterPacket(true, tb_id.Text, tb_pwd.Text, tb_nickName.Text, recovery_Q.Text, tb_recovery_A.Text);

            registerPacket.Type = PacketType.Register;
            registerPacket.registerType = RegisterType.create;
            Program.Send(registerPacket);

        }

        private void btn_Cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Form_Load(object sender, EventArgs e)
        {
            forTest_Connect();
        }
    }

}

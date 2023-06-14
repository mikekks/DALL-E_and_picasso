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

namespace Client.Forms
{
    public partial class Register_Form : MetroFramework.Forms.MetroForm
    {
        public bool duplicateCheck;
        public MetroTextBox[] tb;

        Font mapleFont = new Font(FontManager.fontFamilys[0], 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        Font mapleFont1 = new Font(FontManager.fontFamilys[0], 22, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont1_5 = new Font(FontManager.fontFamilys[0], 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2 = new Font(FontManager.fontFamilys[0], 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2_5 = new Font(FontManager.fontFamilys[0], 13, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        Font mapleFont3 = new Font(FontManager.fontFamilys[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont4 = new Font(FontManager.fontFamilys[0], 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));



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
            forTest_Connect();
            if (!Program.MethodList.ContainsKey(PacketType.Register))
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
            else if (p.registerType == RegisterType.findId)  // 아이디 찾은 경우
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => { R_Register(packet); }));
                }
                else
                {
                    if (p.findId != null)
                    {
                        Console.WriteLine(p.findId);
                        MetroMessageBox.Show(Owner, "아이디 찾기 성공.");
                    }
                    else
                    {
                        MetroMessageBox.Show(Owner, "아이디 찾기 실패");
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
                    if (p.findPassword == true)
                    {
                        MetroMessageBox.Show(Owner, "비밀번호 찾기 성공");
                    }
                    else
                    {
                        MetroMessageBox.Show(Owner, "비밀번호 찾기 실패");
                    }
                    this.Close();
                }
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            forTest_Connect();
            if (!Program.MethodList.ContainsKey(PacketType.Register))
                Program.MethodList.Add(PacketType.Register, R_Register);

            // 비밀번호 확인
            if (tb_pwd.Text != tb_pwd_Check.Text)
            {
                MetroMessageBox.Show(Owner, "비밀번호가 서로 다릅니다.");
                return;
            }

            tb = new MetroTextBox[] { tb_id, tb_pwd, tb_pwd_Check, tb_name, tb_identificationNumber, tb_recovery_A };
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

            var pwdHash = SHA256Helper.ComputeSHA256Hash(tb_pwd.Text);
            var identificationNumberHash = SHA256Helper.ComputeSHA256Hash(tb_identificationNumber.Text);

            // HandleClient.cs, Database.cs 안에서 해싱작업을 하면 패킷길이 오류 발생
            // db에 해당 정보 저장 -> 성공 했는지 안했는지 결과 출력 필요

            RegisterPacket registerPacket =
                new RegisterPacket(true, tb_id.Text, pwdHash, tb_name.Text, identificationNumberHash, recovery_Q.Text, tb_recovery_A.Text);

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
            label1.Font = mapleFont1;

            lab_Answer.Font = mapleFont4;
            lab_i.Font = mapleFont4;
            lab_name.Font = mapleFont4;
            lab_PW.Font = mapleFont4;
            lab_Quest.Font = mapleFont4;
            lab_RePW.Font = mapleFont4;
            lab_RePW.Font = mapleFont4;
            lab_ID.Font = mapleFont4;

            btn_Cancer.Font = mapleFont4;
            btn_Check.Font = mapleFont4;
            btn_IDcheck.Font = mapleFont4;
        }
    }

}

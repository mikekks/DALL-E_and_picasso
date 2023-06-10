using DalleLib.Networks;
using MetroFramework;
using MetroFramework.Controls;
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
using System.Xml.Linq;

namespace Client.Forms
{
    public partial class UpdatePassword : MetroFramework.Forms.MetroForm
    {
        public MetroTextBox[] tb;
        public string name;
        public string identificationNumber; // hash된 값

        public UpdatePassword(string name, string identificationNumber)
        {
            InitializeComponent();

            // 생성자 매개변수로 전달받은 데이터를 해당 변수에 할당합니다.
            this.name = name;
            this.identificationNumber = identificationNumber;
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
        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            forTest_Connect();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            tb = new MetroTextBox[] { updatePw_newPw, updatePw_check};
            foreach (MetroTextBox _tb in tb)
            {
                if (string.IsNullOrWhiteSpace(_tb.Text))
                {
                    _tb.Focus();
                    prompt.ForeColor = Color.Red;
                    prompt.Text = $"{_tb.WaterMark}를 입력해주세요.";
                }
            }

            if (updatePw_newPw.Text != updatePw_check.Text)
            {
                MetroMessageBox.Show(Owner, "비밀번호가 일치하지 않습니다.");
            }

            var pwdHash = SHA256Helper.ComputeSHA256Hash(updatePw_newPw.Text);
            var identificationNumberHash = SHA256Helper.ComputeSHA256Hash(identificationNumber);

            Console.WriteLine("앞에서 전달 받은 name {0}",name);
            Console.WriteLine("앞에서 전달 받은 identificationNumber {0}", identificationNumber);
            
            RegisterPacket registerPacket = new RegisterPacket(name, identificationNumberHash, pwdHash);

            registerPacket.Type = PacketType.Register;
            registerPacket.registerType = RegisterType.resetPassword;
            Program.Send(registerPacket);

            MetroMessageBox.Show(Owner, "비밀번호 재 설정 성공");
            this.Close();
        }
    }
}

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
using DalleLib;

namespace Client.Forms
{
    public partial class UnRegister: MetroFramework.Forms.MetroForm
    {
        public string userId;
        public bool unRegister;

        public UnRegister(string userId)
        {
            InitializeComponent();
            this.userId = userId;
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

        private void UnRegistercs_Load(object sender, EventArgs e)
        {
            forTest_Connect();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {

            Console.WriteLine("앞에서 전달 받은 userId: {0}", userId);

            RegisterPacket registerPacket = new RegisterPacket(userId);

            registerPacket.Type = PacketType.Register;
            registerPacket.registerType = RegisterType.unRegister;
            Program.Send(registerPacket);

            MetroMessageBox.Show(Owner, "회원 탈퇴 성공");
            Application.Exit();
        }
    }
}

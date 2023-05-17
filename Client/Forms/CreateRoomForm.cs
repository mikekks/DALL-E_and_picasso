using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DalleLib.Networks;
using DalleLib.InGame;

namespace Client.Forms
{
    public partial class CreateRoomForm : MetroFramework.Forms.MetroForm
    {
        public CreateRoomForm()
        {
            InitializeComponent();
        }

        private void CreateRoomForm_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_createRoom_Click(object sender, EventArgs e)
        {
            metroPanel1.BringToFront();
            Opacity = 0.5;
            metroPanel1.Visible = true;
            metroProgressSpinner1.Visible = true;
            Opacity = 1;

            int roomId;
            if (Program.roomList == null)
            {
                roomId = 1;
            }
            else
            {
                roomId = Program.roomList.Count;  // room 관련 데이터 이미 갖고 있음
            }
            
            int level = Convert.ToInt32(txt_level.Value);
            string roomName = txt_roonName.Text;

            Room room = new Room(roomId, level, roomName);

            // 이제 패킷으로 만들어서 서버에 보내야 한다.
            // 사용자는 기다려야 함

            if (true)  // 방 만들기 성공의 경우
            {
                MetroMessageBox.Show(Owner, "성공");
                Close();
                

                // 인게임 폼으로 넘어가야함
            }
            else  // 방 만들기 실패의 경우
            {

            }
            //
            

        }



    }
}

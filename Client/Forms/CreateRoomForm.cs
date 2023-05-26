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
            this.Close();
        }

        private void btn_createRoom_Click(object sender, EventArgs e)
        {
            // UI 부분
            /*
            metroPanel1.BringToFront();
            Opacity = 0.5;
            metroPanel1.Visible = true;
            
            Opacity = 1;
            */

            if (!Program.MethodList.ContainsKey(PacketType.RoomCreate))
                Program.MethodList.Add(PacketType.RoomCreate, R_CreateRoom);

            string roomId = txt_roonName.Text;
            
            int level = Convert.ToInt32(txt_level.Value);
            int TotalNum = Convert.ToInt32(cmb_TotalCnt.Text);
            
            string roomName = txt_roonName.Text;

            Room room = new Room(roomId, Program.user.userId, false, 1, TotalNum, level, 5);
            // 이제 패킷으로 만들어서 서버에 보내야 한다.
            // 사용자는 기다려야 함

            RoomPacket roomPacket = new RoomPacket(room, RoomType.New);
            roomPacket.Type = PacketType.RoomCreate;
            roomPacket.user = Program.user;

            room.userList = new List<DalleLib.User> { roomPacket.user };
            roomPacket.userList = room.userList;
            roomPacket.roomType = RoomType.New;

            Program.Send(roomPacket);

        }

        public void R_CreateRoom(Packet packet)
        {
            RoomPacket p = packet as RoomPacket;

            if (p.roomType == RoomType.New)  
            {
                if (p.room != null)  // 방 만들기 성공의 경우 -> Program.room 지정
                {
                    Program.room = new Room(p.room.roomId, p.user.userId, false, 1, p.room.totalNum, p.room.level, 5);

                    Program.room.userList = p.room.userList;
                    MetroMessageBox.Show(Owner, "방만들기 성공");
                    Close();
                }
                else  // 방 만들기 실패의 경우
                {
                    MetroMessageBox.Show(Owner, "방을 생성할 수 없습니다. 다시 시도하세요");
                    Close();
                }

            }
            

           
        }


    }
}

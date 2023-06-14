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

        Font mapleFont = new Font(FontManager.fontFamilys[0], 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont1 = new Font(FontManager.fontFamilys[0], 22, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont2 = new Font(FontManager.fontFamilys[0], 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont3 = new Font(FontManager.fontFamilys[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        Font mapleFont4 = new Font(FontManager.fontFamilys[0], 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));


        public CreateRoomForm()
        {
            InitializeComponent();
            label1.Font = mapleFont2;
            label2.Font = mapleFont2;
            label3.Font = mapleFont2;
            label4.Font = mapleFont2;
            label5.Font = mapleFont;
            btn_createRoom.Font = mapleFont4;
            btn_Cancel.Font = mapleFont4;
        }

        private void CreateRoomForm_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_createRoom_Click(object sender, EventArgs e)
        {


           

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
  
                    if (InvokeRequired)
                    {
                        this.Invoke(new Action(() => { this.Close(); }));
                    }
                }
                else  // 방 만들기 실패의 경우
                {
                    MetroMessageBox.Show(Owner, "방을 생성할 수 없습니다. 다시 시도하세요");

                    if (InvokeRequired)
                    {
                        this.Invoke(new Action(() => { this.Close(); }));
                    }
                }

            }
            

           
        }

        private void btn_createRoom_Click_1(object sender, EventArgs e)
        {
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

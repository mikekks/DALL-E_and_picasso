using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.InGame
{
    [Serializable]
    public class Room
    {
        public int roomID;
        public int level;
        public string roomName;
        public int PartyNum;  // 참여인원
        public int ReadyNum;  // Ready한 인원

        // public Chat lastChat;

        public Room(int roomID, int level, string roomName)
        {
            this.roomID = roomID;
            this.level = level;
            this.roomName = roomName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.InGame
{
    public enum RoomType
    {
        New, Enter
    }
    [Serializable]
    public class Room 
    {
        public int roomID;
        public int level;
        public string roomName;
        public int PartyNum;  // 참여인원
        public int ReadyNum;  // Ready한 인원

        public RoomType roomType;
        public List<User> userList;

        public string Question;
        public string Answer;

        // public Chat lastChat;

        public Room(int roomID, int level, string roomName)
        {
            this.roomID = roomID;
            this.level = level;
            this.roomName = roomName;
        }

        public Room(int roomID, int level, string roomName, int PartyNum, int ReadyNum)
        {
            this.roomID = roomID;
            this.level = level;
            this.roomName = roomName;
            this.PartyNum = PartyNum;
            this.ReadyNum = ReadyNum;
        }
    }
}

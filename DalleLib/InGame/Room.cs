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
        public int TotalNum;  // 들어올 수 있는 총 인원
        public int PartyNum;  // 참여인원
        public int ReadyNum;  // Ready한 인원
        
        
        
        public User Host;
        public List<User> userList;
        public Dictionary<int, bool> ReadyList; // bool은 ready의미

        public string Question;
        public string Answer;

        // public Chat lastChat;
        
        public Room(int roomID, int level, string roomName)
        {
            this.roomID = roomID;
            this.level = level;
            this.roomName = roomName;
        }

        public Room(int roomID, int level, string roomName, int TotalNum, int PartyNum, int ReadyNum)
        {
            this.roomID = roomID;
            this.level = level;
            this.roomName = roomName;
            this.TotalNum = TotalNum;
            this.PartyNum = PartyNum;
            this.ReadyNum = ReadyNum;
        }
    }
}

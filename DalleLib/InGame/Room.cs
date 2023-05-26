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
        public bool create;

        public string roomId;
        // public string hostId;
        public string userId;
        public int level;
        public int totalNum;  // 들어올 수 있는 총 인원
        public int currentNum;  // 참여인원
        public int readyNum;  // Ready한 인원    
        public int round;

        public User Host;
        public List<User> userList;

        public string Question;
        public string Answer;

        public bool nowPlaying;

        // public Chat lastChat;
        

        public Room(string roomId, int level)
        {
            this.roomId = roomId;
            this.level = level;
        }

        public Room(string roomId, int level, int TotalNum, int currentNum, int ReadyNum)
        {
            this.roomId = roomId;
            this.level = level;
            this.totalNum = TotalNum;
            this.currentNum = currentNum;
            this.readyNum = ReadyNum;
        }

        public Room(string roomId,
            string userId, bool nowPlaying, int currentNum, int totalNum, int level, int round)
        {
            this.roomId = roomId;
            this.userId = userId;
            this.nowPlaying = nowPlaying;
            this.currentNum = currentNum;
            this.totalNum = totalNum;
            this.level = level;
            this.round = round;
        }
    }
}

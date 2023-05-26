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
        public int questionId;
        public int level;
        public string roomName;
        public int totalNum;  // 들어올 수 있는 총 인원
        public int currentNum;  // 참여인원
        public int readyNum;  // Ready한 인원    
        
        public User Host;
        public List<User> userList;
        public Dictionary<string, bool> ReadyList; // bool은 ready의미

        public string Question;
        public string Answer;

        public bool nowPlaying;

        // public Chat lastChat;
        

        public Room(string roomId, int level, string roomName)
        {
            this.roomId = roomId;
            this.level = level;
            this.roomName = roomName;
        }

        public Room(string roomId, int level, string roomName, int TotalNum, int currentNum, int ReadyNum)
        {
            this.roomId = roomId;
            this.level = level;
            this.roomName = roomName;
            this.totalNum = TotalNum;
            this.currentNum = currentNum;
            this.readyNum = ReadyNum;
        }

        // hostId -> userId로 변경, roomName 삭제(roomId가 곧 방 제목이므로)
        public Room(string roomId,
            string userId, int questionId, bool nowPlaying, int currentNum, int totalNum, int level)
        {
            this.roomId = roomId;
            this.userId = userId;
            this.questionId = questionId;
            this.nowPlaying = nowPlaying;
            this.currentNum = currentNum;
            this.totalNum = totalNum;
            this.level = level;
        }
    }
}

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
        public string hostId;
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

        // 제가 가져온 변수 부분입니다. 혼동 되지 않게 그대로 가져온 후 기존에 있는 변수는 주석 처리하였습니다.
        ///
        //public string roomId;
        public string userId;
        //public int questionId;
        //public bool nowPlaying;
        public int currentUserNum;
        public int maxUserNum;
        //public int level;
        ///


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
        /*
        public Room(string roomId,
            string hostId, int questionId, bool nowPlaying, int CurrentNum, int TotalNum, int level)
        {
            this.hostId = hostId;
            this.roomId = roomId;
            this.questionId = questionId;
            this.nowPlaying = nowPlaying;
            this.currentNum = CurrentNum;
            this.totalNum = TotalNum;
            this.level = level;
        }
        */
        public Room(string roomId,
            string userId, int questionId, bool nowPlaying, int currentUserNum, int maxUserNum, int level)
        {
            this.userId = userId;
            this.roomId = roomId;
            this.questionId = questionId;
            this.nowPlaying = nowPlaying;
            this.currentUserNum = currentUserNum;
            this.maxUserNum = maxUserNum;
            this.level = level;
        }
    }
}

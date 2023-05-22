using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes.Tables
{
    public class Rooms
    {
        public string roomId, userId;
        public int questionId;
        public bool nowPlaying;
        public int currentUserNum;
        public int maxUserNum;
        public int level;

        public Rooms(string roomId,
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

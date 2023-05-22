using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes.Tables
{
    internal class Users
    {
        public string userId;
        public string roomId;
        public string password;
        public string findQuestion;
        public string answer;
        public bool ready;
        public string Tier;
        public string regDate; // 테이블이 Date 타입이라 formmater로 YYYY-MM-DD 형식으로 바꿔줘야함

        public Users(string userId,
            string roomId, string password, string findQuestion, string answer, bool ready, string Tier, string regDate)
        {
            this.userId = userId;
            this.roomId = roomId;
            this.password = password;
            this.findQuestion = findQuestion;
            this.answer = answer;
            this.ready = ready;
            this.Tier = Tier;
            this.ready = ready;
            this.regDate = regDate;
        }
    }
}

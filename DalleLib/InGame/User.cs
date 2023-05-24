using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DalleLib
{
    [Serializable]
    public class User
    {
        public string userId;
        public string roomId;
        public string password;
        public string username;
        // public DateTime regDate; 타입 논의 필요
        public string recovery_Q;
        public string recovery_A;
        
        public int TryCount;  // 시도횟수
        public int AnsCount;  // 맞춘횟수
        public int WrgCount;  // 틀린횟수

        public int AnsRate;  // 정답률
        public string Tier;  // 티어

        public bool ready;

        // public string userId;
        // public string roomId;
        // public string password;
        public string findQuestion;
        public string answer;
        // public bool ready;
        // public string Tier;
        public string regDate; // 테이블이 Date 타입이라 formmater로 YYYY-MM-DD 형식으로 바꿔줘야함


        public User(string userId, string password)  // user -> server
        {
            this.userId = userId;
            this.password = password;
        }

        public User(string userId, string password, string username, 
            int TryCount, int AnsCount, int WrgCount, int AnsRate, string tier)  // server+db -> user
        {
            this.userId=userId;
            this.password = password;
            this.username = username;
            this.TryCount = TryCount;
            this.AnsCount = AnsCount;
            this.WrgCount = WrgCount;
            this.AnsRate = AnsRate;
            this.Tier = tier;
        }
        /*
        public User(string userId,
           string roomId, string password, string recovery_Q, string recovery_A, bool ready, string Tier, DateTime regDate)
        {
            this.userId = userId;
            this.roomId = roomId;
            this.password = password;
            this.recovery_Q = recovery_Q;
            this.recovery_A = recovery_A;
            this.Tier = Tier;
            this.ready = ready;
            this.regDate = regDate;
        }
        */
        public User(string userId,
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

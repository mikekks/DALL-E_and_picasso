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
        public DateTime regDate;
        public string recovery_Q;
        public string recovery_A;
        
        public int TryCount;  // 시도횟수
        public int AnsCount;  // 맞춘횟수
        public string Tier;  // 티어

        public bool ready;


        public User(string userId, string password)  // user -> server
        {
            this.userId = userId;
            this.password = password;
        }

        public User(string userId, string roomId, string password, string recovery_Q, 
            string recovery_A, bool ready, string Tier, DateTime regDate)
        {
            this.userId = userId;
            this.roomId = roomId;
            this.password = password;
            this.recovery_Q = recovery_Q;
            this.recovery_A = recovery_A;
            this.ready = ready;
            this.Tier = Tier;
            this.ready = ready;
            this.regDate = regDate;
        }
        public User(string userId, int TryCount, int AnsCount)
        {
            this.userId = userId;
            this.TryCount = TryCount;
            this.AnsCount = AnsCount;
        }

        // 8-3 생성자
        public User(string userId, bool ready)
        {
            this.userId = userId;
            this.ready = ready;
        }

        // 12-2 생성자
        public User(string roomId, string userId, int TryCount, int AnsCount)
        {
            this.roomId = roomId;
            this.userId = userId;
            this.TryCount = TryCount;
            this.AnsCount = AnsCount;
        }
    }
}

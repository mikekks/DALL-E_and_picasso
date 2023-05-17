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
        public int userId;
        public string password;
        public string username;
        public DateTime reg_date;
        public string recovery_Q;
        public string recovery_A;

        public int TryCount;  // 시도횟수
        public int AnsCount;  // 맞춘횟수
        public int WrgCount;  // 틀린횟수

        public int AnsRate;  // 정답률
        public string Tier;  // 티어

        public User(int userId, string password)  // user -> server
        {
            this.userId = userId;
            this.password = password;
        }

        public User(int userId, string password, string username, 
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
    }
}

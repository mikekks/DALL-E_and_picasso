using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes.Instances
{
    public class Records
    {
        public string userId;
        public int tryCount, correctCount, failCount;

        public Records(string userId,
            int tryCount, int correctCount, int failCount)
        {
            this.userId = userId;
            this.tryCount = tryCount;
            this.correctCount = correctCount;
            this.failCount = failCount;
        }
    }
}

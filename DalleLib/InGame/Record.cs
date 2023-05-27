using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.InGame
{
    [Serializable]
    public class Records
    {
        public string userId;
        public int tryCount, correctCount;

        public Records(string userId, int tryCount, int correctCount)
        {
            this.userId = userId;
            this.tryCount = tryCount;
            this.correctCount = correctCount;
        }
    }
}

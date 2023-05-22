using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.InGame
{
    public class Records
    {
        public string userId, roomId;
        public int tryCount, correctCount;

        public Records(string userId,
            string roomId, int tryCount, int correctCount)
        {
            this.userId = userId;
            this.roomId = roomId;
            this.tryCount = tryCount;
            this.correctCount = correctCount;
        }
    }
}

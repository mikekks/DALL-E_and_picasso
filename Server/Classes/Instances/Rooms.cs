using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes.Instances
{
    public class Rooms
    {
        public string roomId, userId;
        public int capacity;

        public Rooms(string roomId, string userId,
            int capacity)
        {
            this.roomId = roomId;
            this.userId = userId;
            this.capacity = capacity;
        }
    }
}

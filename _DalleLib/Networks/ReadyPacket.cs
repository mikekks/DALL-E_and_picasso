using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalleLib.InGame;

namespace DalleLib.Networks
{
    public class ReadyPacket : Packet
    {
        // 어떤 방에서 누가 레디를 했는지
        public User user;
        public Room room;
        public ReadyPacket(User user, Room room)
        {
            Type = PacketType.Ready;
            this.user = user;
            this.room = room;
        }  
    }
}

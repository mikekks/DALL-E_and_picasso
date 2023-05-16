using DalleLib.InGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.Networks
{
    public class AnswerPacket : Packet
    {
        // ready 인지 ans인지  public User user;
        public User user;
        public Room room;
        public AnswerPacket(User user, Room room)
        {
            Type = PacketType.Answer;
            this.user = user;
            this.room = room;
        }

        
    }
}

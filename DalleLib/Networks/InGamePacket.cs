using DalleLib.InGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.Networks
{
    public enum respondType
    {
        Ready, Answer
    }

    [Serializable]
    public class InGamePacket : Packet
    {
        // ready 인지 ans인지  public User user;
        public User user;
        public Room room;

        public respondType respondType;
        public bool ready;
        public string answer;

        public InGamePacket(User user, Room room)  // ready 
        {
            Type = PacketType.InGame;
           // respondType = respondType.Ready;

            this.user = user;
            this.room = room;
        }



        
    }
}

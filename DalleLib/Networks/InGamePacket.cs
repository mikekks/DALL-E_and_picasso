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
        Ready, Start, Answer, NextGame, End
    }

    [Serializable]
    public class InGamePacket : Packet
    {
        // ready 인지 ans인지  public User user;
        public User user;
        public Room room;

        public respondType respondType;
        public bool ready;
        public int correct;

        public int Round;
        public string Answer;

        public List<Records> records;

        public InGamePacket(User user, Room room)  // ready 
        {
            Type = PacketType.InGame;
           // respondType = respondType.Ready;

            this.user = user;
            this.room = room;
        }


        
        
    }
}

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
        Ready, Start, Chat, Loading, Answer, NextGame, End
    }

    [Serializable]
    public class InGamePacket : Packet
    {
        // ready 인지 ans인지  public User user;
        public User user;
        public Room room;

        public respondType respondType;
        public bool ready;  // 유저 -> 서버 패킷에서만 사용
        public bool start;
        public bool IsHost;
        public int correct;

        public int Round;
        public string Answer;

        public List<string> SendAnsList;
        public List<Records> records;

        public string Chat;

        public InGamePacket(User user, Room room)  // ready 
        {
            Type = PacketType.InGame;

            this.user = user;
            this.room = room;
        }


        
        
    }
}

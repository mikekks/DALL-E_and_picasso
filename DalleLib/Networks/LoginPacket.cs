using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalleLib.InGame;

namespace DalleLib.Networks
{
    [Serializable]
    public class LoginPacket : Packet
    {
        public bool success = false;
        public User user;
        public Dictionary<int, Room> roomList;
        //public List<Room> rooms;
        
        public LoginPacket(int userId, string password)
        {
            Type = PacketType.Login;
            user = new User(userId, password);
        }

        public LoginPacket(bool success, User user, Dictionary<int, Room> roomList)
        {
            Type = PacketType.Login;

            this.success = success;
            this.user = user;
            this.roomList = roomList;
        }
    }
}

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
        public List<Room> roomList;
        
        public LoginPacket(string userId, string password)
        {
            Type = PacketType.Login;
            user = new User(userId, password);
        }

        public LoginPacket(bool success, User user, List<Room> roomList)
        {
            Type = PacketType.Login;

            this.success = success;
            this.user = user;
            this.roomList = roomList;
        }
    }
}

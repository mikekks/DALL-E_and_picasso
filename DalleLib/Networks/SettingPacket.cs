using DalleLib.InGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.Networks
{
    [Serializable]
    public class SettingPacket : Packet
    {
        public User user;
        public List<Room> roomList;
        public SettingPacket(string userId, string password) 
        {
            Type = PacketType.Setting;
            user = new User(userId, password);
        }

        public SettingPacket(User user, List<Room> roomList)
        {
            this.user = user;
            this.roomList = roomList;
        }
    }
}

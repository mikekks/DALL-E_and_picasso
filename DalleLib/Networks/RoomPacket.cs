using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalleLib.InGame;

namespace DalleLib.Networks
{
    public enum RoomType
    {
        New, Enter
    }

    public class RoomPacket : Packet
    {
        public Room room;
        public RoomType roomType;
        public User user; // 방장의미
        public Dictionary<bool, User> userList; // bool은 ready의미
        // Quest

        public RoomPacket(Room room, RoomType roomType) 
        {
            this.room = room;
            this.roomType = roomType;
            Type = PacketType.Room;
        }
    }
}

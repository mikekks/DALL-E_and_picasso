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

    [Serializable]
    public class RoomPacket : Packet
    {
        public Room room;
        public RoomType roomType;
        public User user; // 방장의미
        public List<User> userList;
        public Dictionary<int, bool> ReadyList; // bool은 ready의미
        // Quest

        public RoomPacket(Room room, RoomType roomType) // 어떤 방에 들어갈 때 사용하는 패킷
        {
            this.room = room;
            this.roomType = roomType;
            Type = PacketType.Room;
        }
    }
}

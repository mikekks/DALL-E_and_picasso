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
        public Room room;  // 생성하려는 방 또는 입장하려는 방 객체
        public RoomType roomType;
        public User user; // 방에 입장하려는 유저 객체, 또는 방 생성하려는 유저 객체
        public List<User> userList;

        public RoomPacket(Room room, RoomType roomType) // 어떤 방에 들어갈 때 사용하는 패킷
        {
            this.room = room;
            this.roomType = roomType;
            Type = PacketType.Room;
        }
    }
}

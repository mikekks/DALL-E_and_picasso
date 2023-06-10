using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.Networks
{
    public enum PacketType
    {
        Header, Close, Setting,
        Login, DuplicateLogin, Logout, Register,
        InGame, Chat, Room, RoomCreate, UpdatePassword
    }

    [Serializable]
    public class Packet
    {
        public const int BUFFER_SIZE = 4096;

        public PacketType Type;

        public Packet(PacketType Type)
        {
            this.Type = Type;
        }

        public Packet() { }

        public byte[] Serialize()
        {
            return Serialize(this);
        }
        public static byte[] Serialize(object o)  // ! object -> Packet
        {
            MemoryStream ms = new MemoryStream();
            new BinaryFormatter().Serialize(ms, o);
            return ms.ToArray();
        }

        public static object Deserialize(byte[] ba)
        {
            MemoryStream ms = new MemoryStream(ba, 0, ba.Length);
            return new BinaryFormatter().Deserialize(ms);
        }
       
    }
}

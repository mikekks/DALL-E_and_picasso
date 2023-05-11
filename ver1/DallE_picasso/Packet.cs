using System;
using System.IO;
using System.Runti

namespace Networks
{
	public enum PacketType
	{
		Header, Close,
		Login, DulplicateLogin, Logout, Register,
		Chat, Room
	}

	[Serializable]
	public class Packet
	{
		public const int BUFFER_SIZE = 4096;

		public PacketType Type;

		public Packet()
		{

		}

        public Packet(PacketType Type)
        {
			this.Type = Type;
        }



    }
}
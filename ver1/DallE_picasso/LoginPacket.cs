using System;
using Networks

namespace Networks {

    [Serializable]
    public class LoginPacket : Packet
	{
        public bool success = false;

        public LoginPacket()
		{
			
		}

	}
}

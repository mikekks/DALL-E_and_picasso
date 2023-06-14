using DalleLib.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.InGame
{
    [Serializable]
    public class Chat
    {
        public string sender;
        public DateTime date;
        public string roomId;
        public string chat;

        public Chat(string sender, string roomId, string chat, DateTime date)  // 클라이언트가 보낼 때
        {
            this.sender = sender;
            this.roomId = roomId;
            this.chat = chat;
            this.date = date;
        }

        public Chat(string sender, string roomId, string chat)  // 서버가 보낼 때
        {
            this.sender = sender;
            this.roomId = roomId;
            this.chat = chat;
        }
    }
}

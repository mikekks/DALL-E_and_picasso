using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalleLib.Networks
{

    public enum RegisterType
    {
        duplicate, create, findId, findPassword
    }
    [Serializable]

    public class RegisterPacket : Packet
    {
        public bool duplicate;
        public bool regiser_Success;
        public RegisterType registerType;
        public bool findId;
        public bool findPassword;

        public string id;
        public string password;
        public string nickName;
        public string recovery_Q;
        public string recovery_A;
        public DateTime regDate;

        public RegisterPacket(string id)  // 중복도 검사 & 아이디 찾기를 위함
        {
            this.id = id;
        }

        public RegisterPacket(bool regiser_Success, string id, string password, string nickName, string recovery_Q, string recovery_A)
        {
            this.regiser_Success = regiser_Success;
            this.id = id;
            this.password = password;
            this.nickName = nickName;
            this.recovery_Q = recovery_Q;
            this.recovery_A = recovery_A;
        }

        public RegisterPacket(string id, bool regiser_Success)
        {
            this.regiser_Success = regiser_Success;
            this.id = id;
        }

        // 아이디 찾기를 위함
        public RegisterPacket(string recovery_Q, string recovery_A)
        {
            this.recovery_Q = recovery_Q;
            this.recovery_A = recovery_A;
        }

        // 비밀번호 찾기를 위함
        public RegisterPacket(string id, string recovery_Q, string recovery_A)
        {
            this.id = id;
            this.recovery_Q = recovery_Q;
            this.recovery_A = recovery_A;
        }

        public RegisterPacket(string password, DateTime regDate)
        {
            this.password = password;
            this.regDate = regDate;
        }

    }
}

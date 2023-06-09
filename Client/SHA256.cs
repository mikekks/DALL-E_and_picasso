using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Client
{
    public static class SHA256Helper
    {
        public static string ComputeSHA256Hash(string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // 데이터를 바이트 배열로 변환합니다.
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);

                // 데이터를 해시화하여 해시 값을 계산합니다.
                byte[] hashBytes = sha256.ComputeHash(dataBytes);

                // 해시 값을 문자열로 변환합니다.
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2")); // x2는 16진수 형식으로 출력하기 위한 지정자입니다.
                }
                string hashValue = stringBuilder.ToString();

                // 해시 값을 반환합니다.
                return hashValue;
            }
        }
    }
}

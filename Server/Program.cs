using System;
using System.Net;
using System.Net.Sockets;
using DalleLib;
using DalleLib.InGame;
using DalleLib.Networks;
using Server.Classes;
using Server.Classes.Instances;


namespace Server
{
    class Program
    {
        static ushort port = 9999;
        static TcpListener server = null;
        public TcpClient Client_Socket = null;

        static void Main(string[] args)
        {
            /// 데이터베이스 접속
            if(Database.connect()) // bool 값으로 리턴되는 connectDB 함수 입니다. DB접속이 완료되면 true를 리턴합니다.
            {
                Users signUpTestUser = new Users(userId: "myUserId3",password: "myPassword3", email: "myEmail@example.com", answer: "myAnswer");
                Database.signUp(signUpTestUser);

                Console.WriteLine(Database.login(userId: "myUserId3", password: "myPassword3"));
                // DB에 로그인하는 함수 입니다. 파라미터로 받은 userId의 비밀번호가 해당 유저의 올바른 password라면, 해당 User의 인스턴스를 반환합니다.
            }
            ///

            server = new TcpListener(IPAddress.Any, port);
            
            server.Start();

            while (true)
            {
                HandleClient h_client = new HandleClient(server.AcceptTcpClient());

                Console.WriteLine("client connect!");

            }
        }
    }
}
using System;
using System.Net;
using System.Net.Sockets;
using DalleLib;
using DalleLib.InGame;
using DalleLib.Networks;
using Server.Classes;
using Server.Classes.Tables;


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
                // 1. 회원가입하는 함수
                //Console.WriteLine("1.회원가입하는 함수");
                //Database.signUp(userId:"test1",password:"test1Pw",findQuestion:"가장 기억에 남는 장소는?", answer:"집",regDate: "2023-05-22");

                // 2. 로그인하는 함수
                Console.WriteLine("2. 로그인하는 함수");
                Console.WriteLine(Database.login(userId: "test1", password: "test1Pw"));
                // DB에 로그인하는 함수 입니다. 파라미터로 받은 userId의 비밀번호가 해당 유저의 올바른 password라면, 해당 User의 인스턴스를 반환합니다.

                // 3. 본인기록 가져오는 함수
                Console.WriteLine("3. 본인기록 가져오는 함수");
                Console.WriteLine(Database.getRecords(userId: "test1"));


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
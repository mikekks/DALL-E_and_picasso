using System;
using System.Net;
using System.Net.Sockets;
using DalleLib;
using DalleLib.InGame;
using DalleLib.Networks;
using Server.Classes;
using Server.Classes.Tables;
using static System.Net.Mime.MediaTypeNames;


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

                // 10. 문제 만드는 함수
                // Console.WriteLine("10. 문제 만드는 함수");
                // Console.WriteLine(Database.makeDalleQuestion(questionId: 8, imageUrl: "testUrl", keyword_1: "Potato", keyword_2: "Mouse", keyword_3: "Rain" ));

                // 4-1 방 만드는 함수 - questionId(Dalle), userId(Users) 기존에 있는 거 써야함 (ex. userId: test1, questionId: 8)
                // Console.WriteLine("4-1. 방 만드는 함수");
                // Console.WriteLine(Database.makeNewRoom(roomId: "뉴비", userId: "test1", questionId: 8, maxUserNum: 4, level: 2));
                
                // 4-2 방 리스트 불러오는 함수
                Console.WriteLine("4-2 방 리스트 불러오는 함수");
                Console.WriteLine(Database.getRoomsList());

                // 5. 방 진입여부 확인하는 함수
                Console.WriteLine("5. 방 진입여부 확인하는 함수");
                Console.WriteLine(Database.checkEnterRoom(roomId: "뉴비"));

                // 6. 방 진입하는 함수
                Console.WriteLine("6. 방 진입하는 함수");
                Console.WriteLine(Database.enterRoom_Rooms(roomId: "뉴비", userId: "test1"));


                // 3. 본인기록 가져오는 함수
                // Dalle 테이블 -> Rooms 테이블 미리 생성 되어야 함
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
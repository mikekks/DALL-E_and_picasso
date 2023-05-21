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
                // 2. 회원가입하는 함수
                Console.WriteLine("****");
                Users signUpTestUser = new Users(userId: "myUserId4",password: "myPasswor43", email: "myEmail@example.com", answer: "myAnswer");
                Database.signUp(signUpTestUser);

                // 1. 로그인하는 함수
                Console.WriteLine("****");
                Console.WriteLine(Database.login(userId: "myUserId4", password: "myPassword4"));
                // DB에 로그인하는 함수 입니다. 파라미터로 받은 userId의 비밀번호가 해당 유저의 올바른 password라면, 해당 User의 인스턴스를 반환합니다.

                // 3. 방 만들기 함수
                Console.WriteLine("****");
                Rooms createNewRoomTestRoom = new Rooms(roomId:"RoomOfGoldUser", userId: "myUserId4", capacity: 5);
                Console.WriteLine(Database.createNewRoom(createNewRoomTestRoom));

                // 4. 방 리스트 불러오기 함수
                Console.WriteLine("****");
                Console.WriteLine(Database.getRoomList());

                // 8. 해당 문제애 대한 답(키워드 3개)을 반환하는 함수
                Console.WriteLine("****");
                Console.WriteLine(Database.getDalleKeywords(questionId: "1"));
                List<Dalle> exampleDalle = Database.getDalleKeywords(questionId: "1");
                Console.WriteLine(exampleDalle[0].keyword_1);
                Console.WriteLine(exampleDalle[0].keyword_2);
                Console.WriteLine(exampleDalle[0].keyword_3);

                // 9-1 정답 확인 함수 (필요해서 추가)
                Console.WriteLine("****");
                Console.WriteLine(Database.checkRightAnswer(questionId:"1",answer:"banana"));
                Console.WriteLine(Database.checkRightAnswer(questionId: "1", answer: "robot"));

                // 9-2 유저의 게임 기록을 저장하는 함수
                Console.WriteLine("****");
                Records newUserRecords = new Records(userId: "myUser", tryCount: 3, correctCount: 1, failCount: 2);
                Console.WriteLine(Database.recordUserGame(newUserRecords));

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
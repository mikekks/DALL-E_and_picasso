using System;
using System.Net;
using System.Net.Sockets;
using DalleLib;
using DalleLib.InGame;
using DalleLib.Networks;
using Server.Classes;
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
            if (Database.connect()) // bool 값으로 리턴되는 connectDB 함수 입니다. DB접속이 완료되면 true를 리턴합니다.
            {
                // 1. 회원가입하는 함수
                Console.WriteLine("1.회원가입하는 함수");
                Database.signUp(userId:"test5",password:"test3Pw",findQuestion:"가장 기억에 남는 장소는?", answer:"집",regDate: "2023-05-22");

                // 2. 로그인하는 함수
                Console.WriteLine("2. 로그인하는 함수");
                Console.WriteLine(Database.login(userId: "test5", password: "test3Pw"));
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
                Console.WriteLine(Database.enterRoom_Rooms(roomId: "뉴비", userId: "test3"));

                // 7. 레디하는 함수
                Console.WriteLine("7. 레디하는 함수");
                Console.WriteLine(Database.ready(userId: "test1", roomId: "뉴비"));

                // 7-1 레디 취소하는 함수
                // Console.WriteLine("7-1 레디 취소하는 함수");
                // Console.WriteLine(Database.readyCancel(userId: "test1", roomId: "뉴비"));

                // 8. 레디 확인하는 함수
                Console.WriteLine("8. 레디 확인하는 함수");
                Console.WriteLine(Database.checkUsersReady(roomId: "뉴비"));

                // 9. 게임 실행하는 함수 (안에 8번함수로 분기처리)
                Console.WriteLine("9. 게임 실행하는 함수");
                Console.WriteLine(Database.startGame(roomId: "뉴비"));

                // 9-1. 게임 실행하게 되면 레코드 테이블에 유저 등록
                Console.WriteLine("9-1. 게임 실행하게 되면 레코드 테이블에 유저 등록");
                // Console.WriteLine(Database.registerRecordTable(userId: "test1", roomId: "뉴비"));
                // Console.WriteLine(Database.registerRecordTable(userId: "test2", roomId: "뉴비"));
                // Console.WriteLine(Database.registerRecordTable(userId: "test3", roomId: "뉴비"));

                // 11. 문제 맞추기 함수
                Console.WriteLine(Database.checkAnswer(userId: "test1", roomId: "뉴비", questionId: 8, userAnswer: "Potato"));

                // 12. 방금 게임에 대한 기록 가져오는 함수
                Console.WriteLine(Database.getRecordLastGame(userId: "test1", roomId: "뉴비"));

                // 호스트 순서 1 -> 2 -> 10 -> 4-1 -> 4-2 -> 6 -> 7 or 7-1 -> 8 -> 9 -> 9-1 -> 11 -> 12
                // 참가자 순서 1 -> 2 -> 5 -> 6 -> 7 or 7-1 -> 9-1 -> 11 -> 12

                // 3. 본인기록 가져오는 함수
                // Dalle 테이블 -> Rooms 테이블 미리 생성 되어야 함
                Console.WriteLine("3.본인기록 가져오는 함수");
                Console.WriteLine(Database.getRecords(userId: "test1"));
            }


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
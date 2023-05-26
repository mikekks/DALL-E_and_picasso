using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DalleLib;
using DalleLib.InGame;
using DalleLib.Networks;

namespace Server.Classes
{
    public class HandleClient
    {
        public TcpClient client;
        NetworkStream stream;
        public Thread RecvThread;

        public User user;  // 해당 스레드가 어떤 유저랑 통신하는지 결정

        public int[] AnswerList = new int[7];

        public static List<Room> roomList;


        ////////////// 테스트를 위한 임시 변수들 //////////////
        
        int Round = 2;  // 남은 라운드 의미
        bool flipflop = true;
        public static int readyChk = 0;

        ////////////// 테스트를 위한 임시 변수들 //////////////


        public HandleClient(TcpClient client)
        {
            this.client = client;
            stream = client.GetStream();

            roomList = new List<Room>();
            
            RecvThread = new Thread(Recieve);
            RecvThread.IsBackground = true;
            RecvThread.Start();
        }

        // core
        public void Recieve()
        {
            byte[] Length = new byte[4];
            byte[] RecvData = null;

            while (true)
            {
                try
                {
                    stream.Read(Length, 0, 4);
                    int size = BitConverter.ToInt32(Length, 0);
                    RecvData = new byte[size];  // ! 데이터가 끊어서 올 수도 있나?
                    stream.Read(RecvData, 0, size);
                }
                catch(SocketException ex)
                {
                   
                    Console.WriteLine(ex);
                    break;
                }
                catch(Exception ex)
                {

                    Console.WriteLine(ex);
                    break;
                }


                object Obj = null;
                Obj = Packet.Deserialize(RecvData);

                if (Obj == null)
                {
                    continue;  // 데이터가 아예 오지 않음을 의미
                }

                Packet packet = Obj as Packet;

                if(packet.Type == PacketType.Login)
                {
                    LoginPacket p = packet as LoginPacket;

                    // db에 해당 정보 보내기
                    user = Database.login(userId: p.user.userId, password: p.user.password);
              
                    if (user != null)  // 로그인 성공 경우
                    {

                        // rooms 정보 db에서 불러오기 for문으로 저장
                        roomList = Database.getRoomsList();

                        p = new LoginPacket(true, user, roomList);
                        Send(p);
                    }
                    else  // 로그인 실패 경우
                    {
                        p = new LoginPacket(false, user, null);  // ! null로 해도 되나?
                        Send(p);
                    }



                }
                else if (packet.Type == PacketType.Setting)
                {
                    SettingPacket p = packet as SettingPacket;
                    roomList = Database.getRoomsList();

                    p.roomList = roomList;
                    Send(p);

                }
                else if (packet.Type == PacketType.Register)
                {
                    RegisterPacket p = packet as RegisterPacket;
                    
                    if(p.registerType == RegisterType.duplicate)
                    {
                        // DB에서 해당 아이디(p.id) 중복도 검사
                        //
                        //

                        bool test = true;  // 테스트 코드
                        RegisterPacket sendPacket = new RegisterPacket(p.id, false);

                        if (test)  // 중복도 검사 통과
                        {
                            sendPacket.duplicate = true; 
                            
                        }
                        else  // 중복되는 아이디 있음
                        {
                            sendPacket.duplicate = false;
                        }

                        sendPacket.Type = PacketType.Register;
                        sendPacket.registerType = RegisterType.duplicate;
                        Send(sendPacket);

                    }
                    else if(p.registerType == RegisterType.create)
                    {
                        //  db에 해당 유저의 정보 저장
                        bool suc = Database.signUp(userId: p.id, password: p.password, recovery_Q: p.recovery_A, recovery_A: p.recovery_A, regDate: DateTime.Now);

                        RegisterPacket sendPacket;
                        if (suc)  // 회원가입 성공
                        {
                            sendPacket = new RegisterPacket(p.id, true);
                        }
                        else  // 회원가입 실패
                        {
                            sendPacket = new RegisterPacket(p.id, false);
                        }

                        sendPacket.Type = PacketType.Register;
                        sendPacket.registerType = RegisterType.create;
                        Send(sendPacket);

                    }
                }
                else if (packet.Type == PacketType.RoomCreate)
                {
                    RoomPacket p = packet as RoomPacket;

                    if (p.roomType == RoomType.New)
                    {
                        // db에서 요청하는 방과 중복되는게 있는지 확인
                        // 
                        //


                        // db에 해당 방 생성
                        bool suc = Database.makeNewRoom(roomId: p.room.roomId, userId: p.room.userId, totalNum: p.room.totalNum, level: p.room.level);
                        

                        if (suc)  // 새로운 방 생성 성공 -> 해당 방 바로 입장
                        {
                            Database.enterRoom_Rooms(roomId: p.room.roomId, userId: p.user.userId);
                            
                            Room room = new Room(p.room.roomId, p.user.userId, false, 1, p.room.totalNum, p.room.level, 5);
                            room.Host = p.user;

                            RoomPacket sendPacket = new RoomPacket(room, RoomType.New);
                            sendPacket.Type = PacketType.RoomCreate;
                            room.userList = new List<User> { p.user };
                            sendPacket.userList = room.userList;
                            sendPacket.room.Host = p.user;

                            sendPacket.roomType = p.roomType;
                            sendPacket.room.create = true;

                            Console.WriteLine("방 생성 성공");
                            Send(sendPacket);

                        }
                        else  // 방 생성 실패
                        {
                            RoomPacket sendPacket = new RoomPacket(null, RoomType.New);
                            sendPacket.Type = PacketType.RoomCreate;
                            sendPacket.roomType = p.roomType;
                            Send(sendPacket);
                        }
                    }
                }

                else if (packet.Type == PacketType.Room)
                {
                    RoomPacket p = packet as RoomPacket;
                    /*
                    if(p.roomType == RoomType.New)
                    {
                      
                    }
                    */
                    if (p.roomType == RoomType.Enter)
                    {
                       
                        if (Database.checkEnterRoom(roomId: p.room.roomId))  // 입장 가능을 의미
                        {
                            // p.room.roomID로 해당 룸을 DB에서 쿼리해서 PartyNum 1 증가(수정)시킨다.
                            Room _room = Database.enterRoom_Rooms(roomId: p.room.roomId, userId: p.user.userId);

                            // 유저 리스트에  p.room.userList 를 추가시킨다.
                            _room.userList = Database.getReadyList(roomId: p.room.roomId);


                            //_room.currentNum++;
                            RoomPacket sendPacket = new RoomPacket(_room, RoomType.Enter);
                            Send(sendPacket);

                        }
                        else  // 입장 불가를 의미
                        {

                        }
                    }
                }
                else if (packet.Type == PacketType.InGame)
                {
                    InGamePacket p = packet as InGamePacket;
                    if(p.respondType == respondType.Ready)  // Ready를 보냈을 경우 모든 유저의 레디리스트 갱신 필요
                    {
                        // db에서 해당 유저가 레디한 유저인지 파악
                        bool suc = Database.checkSpecificUserReady(p.user.userId);

                        if (p.ready && !suc)  // 방금 레디한 경우 : db에는 ready x,  하지만 패킷에는 Ready = true
                        {

                            // db에 해당 방의 해당 유저를 레디 상태로 수정
                            Database.ready(userId: p.user.userId, roomId: p.room.roomId);

                            // 그 후 다시 해당 방의 유저리스트 쿼리
                            p.room.userList = Database.getReadyList(roomId: p.room.roomId);

                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);
                            sendPacket.Type = PacketType.InGame;
                            sendPacket.respondType = respondType.Ready;
                            sendPacket.ready = true;
                            Send(sendPacket);
                            
                        }
                        else { // 예전에 레디한 경우 or 레디하지 않은 경우
                            Database.checkUsersReady(roomId: p.room.roomId);
                        }


                    }
                    else if (p.respondType == respondType.Start)
                    {
                        // DB에서 방장인지 확인(이 부분은 보류), 모두 레디했는지 확인  : p.room.roomID, p.user.userId 사용
                        bool suc = Database.checkUsersReady(roomId: p.room.roomId);
                        
                        if (suc) 
                        {

                            Database.startGame(roomId: p.room.roomId);

                            // 게임 실행하게 되면 레코드 테이블에 유저 등록
                            // ! 계속 업데이트 하는 거 조심해야함
                            Database.registerRecordTable(userId: p.user.userId, roomId: p.room.roomId);

                            string img = "https://pbs.twimg.com/media/Fb_Sec8WQAIbCZV?format=jpg&name=medium";
                            // Dalle roomid가 식별번호 되야 할듯 해당 room 저장
                            //
                            //

                            p.room.Question = img;
                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                            sendPacket.Type = PacketType.InGame;
                            sendPacket.respondType = respondType.Start;  // 오직 여기서만 Start 패킷 보내야 함
                            sendPacket.ready = true;
                            Send(sendPacket);
                        }
                        else
                        {

                        }

                    }
                    else if (p.respondType == respondType.Answer)
                    {
                        string tmpAns = p.Answer;


                        // DB에서 해당 룸( p.room.roomID ) 에 
                        // 매핑되는 문제의 정답 단어 불러오기
                        //

                        int idx = Database.checkAnswer(userId: p.user.userId, roomId: p.room.roomId, userAnswer: p.Answer);

                        //Database.getKeyword(p.room.roomId);
  
                        InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                        sendPacket.Type = PacketType.InGame;
                        sendPacket.respondType = respondType.Answer;
                        sendPacket.Answer = tmpAns;
                        AnswerList[idx] = 1;  // 중복정답 커버

                        sendPacket.correct = idx;                    

                        Send(sendPacket);
                    }
                    else if (p.respondType == respondType.NextGame)  // 현재 라운드 종료, 다음 라운드 진행
                    {
                        // 해당 게임의 모든 라운드가 끝났는지 확인, 일단 5라운드 상수로 지정
                        //
                        //
                        if (Round == 0)  // 해당 게임의 모든 라운드가 끝남을 의미
                        {
                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);
                            sendPacket.Type = PacketType.InGame;
                            sendPacket.respondType = respondType.End;

                            // DB에서 해당 게임의 결과 가져오기
                            //
                            //
                            List<Records> records = Database.getRecordEveryone( roomId: p.room.roomId);
                            sendPacket.records = records;

                            Send(sendPacket);
                        }
                        else
                        {
                            Round--;  // 테스트 코드

                            // 방장인지 확인 : 방장쪽의 패킷에서 보내면 문제 변경하는거로
                            //
                            //

                            // Dall-e와 통신 or Dall-e DB 접근 -> 달리 이미지랑 단어 조합 받아오기
                            //
                            //
                            string newQuestion = "https://i.ytimg.com/vi/HUNFD3ktkQ4/maxresdefault.jpg";
                            string newQuestion2 = "https://i.ytimg.com/vi/K0TW-zcbEuY/mqdefault.jpg";
                            // 이미지뿐만 아니라 단어도 필요

                            // DB에서 해당 방(p.room.roomID)의 문제 변경
                            //
                            //

                            if (flipflop)
                            {
                                flipflop = false;
                                p.room.Question = newQuestion;
                            }
                            else
                            {
                                flipflop = true;
                                p.room.Question = newQuestion2;
                            }

                            
                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                            sendPacket.Type = PacketType.InGame;
                            sendPacket.respondType = respondType.Start;  // 다시 시작을 의미
                            sendPacket.ready = true;
                            Send(sendPacket);
                        }

                    }
                }

            }

        }

        public void Send(Packet packet)
        {
            lock (this)
            {
                byte[] sendData = packet.Serialize();
                byte[] Length = BitConverter.GetBytes(sendData.Length);

                stream.Write(Length, 0, 4);  // ! 왜 4일까?
                stream.Write(sendData, 0, sendData.Length);
                stream.Flush();
            }
        }
    }
}

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
using MySql.Data.MySqlClient;


namespace Server.Classes
{
    public class HandleClient
    {
        public TcpClient client;
        NetworkStream stream;
        public Thread RecvThread;

        public User user;  // 해당 스레드가 어떤 유저랑 통신하는지 결정

       

        public static List<Room> roomList;
        public static List<List<string>> AnsList;
        public List<string> SendAnsList;


         
        ////////////// 테스트를 위한 임시 변수들 //////////////

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

                        // rooms 정보 db에서 불러오기
                        roomList = Database.getRoomsList();

                        // 유저 게임 기록 불러오기
                        User _user = Database.getRecords(p.user.userId);    
                        if(_user != null)
                        {
                            user.TryCount = _user.TryCount;
                            user.AnsCount = _user.AnsCount;
                        }

                        // ! 이미 접속 처리
                        if (!Program.loginClient(this))
                        {
                            
                        }

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
                            Database.EnterOrExit_Room(roomId: p.room.roomId, userId: p.user.userId, 1);
                            
                            Room room = new Room(p.room.roomId, p.user.userId, false, 1, p.room.totalNum, p.room.level, 5);
                            room.Host = p.user;

                            RoomPacket sendPacket = new RoomPacket(room, RoomType.New);
                            sendPacket.Type = PacketType.RoomCreate;
                            room.userList = new List<User> { p.user };
                            sendPacket.userList = room.userList;
                            sendPacket.room.Host = p.user;
                            sendPacket.user = p.user;

                            sendPacket.roomType = p.roomType;
                            sendPacket.room.create = true;

                            Console.WriteLine("방 생성 성공");
                            Send(sendPacket);

                            
                            // 새로운 방을 다른 유저에게 알림

                            roomList = Database.getRoomsList();
                            foreach (KeyValuePair<string, HandleClient> curUser in Program.clientList)
                            {
                                
                                SettingPacket notifyPacket = new SettingPacket(curUser.Value.user, roomList);
                                    
                                Program.clientList[curUser.Key].Send(notifyPacket);
                                
                            }

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
                            // 유저 리스트에  p.room.userList 를 추가시킨다.
                            Room _room = Database.EnterOrExit_Room(roomId: p.room.roomId, userId: p.user.userId, 1);

                            _room.userList = Database.getReadyList(roomId: p.room.roomId);

                            RoomPacket sendPacket = new RoomPacket(_room, RoomType.Enter);
                            Send(sendPacket);

                            
                            // 다른 유저에게 해당 유저가 들어왔음을 알림
                            foreach (User curUser in _room.userList)
                            {
                                InGamePacket notifyPacket = new InGamePacket(curUser, _room);
                                notifyPacket.respondType = respondType.Ready;
                                Program.clientList[curUser.userId].Send(notifyPacket);
                            }


                        }
                        else  // 입장 불가를 의미
                        {

                        }
                    }
                    else if(p.roomType == RoomType.Exit) 
                    {

                        // 레디 false 만들어주기
                        Database.readyCancel(p.room.roomId, p.user.userId);


                        // 방 나가기
                        Database.MapRoom(null, p.user.userId);

                        
                        if (Database.getSpecificRooms(p.room.roomId).currentNum == 1)
                        {
                            // 만약 방에 혼자였다면, 방을 아예 삭제
                            Database.InableRoom(p.room.roomId);
                        }
                        else
                        {
                            // 만약 방에 다른 사람이 있었다면, curNum 1 감소
                            Database.EnterOrExit_Room(p.room.roomId, p.user.userId, -1);
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
                            Database.ready(p.user.userId, p.room.roomId);
                        }
                        else if(suc && !p.ready)  // 레디 취소의 경우
                        {
                            Database.readyCancel(p.user.userId, p.room.roomId);
                        }
                        
                        // 그 후 다시 해당 방의 유저리스트 쿼리
                        p.room.userList = Database.getReadyList(roomId: p.room.roomId);

                        InGamePacket sendPacket = new InGamePacket(p.user, p.room);
                        sendPacket.Type = PacketType.InGame;
                        sendPacket.respondType = respondType.Ready;

                        foreach(User user in p.room.userList)
                        {
                            Program.clientList[user.userId].Send(sendPacket);
                        }
                        

                    }
                    else if (p.respondType == respondType.Start)
                    {
                        // 방장인지 확인
                        Room _room = Database.getSpecificRooms(p.room.roomId);

                        if (_room.userId != p.user.userId)  // 방장이 아닌데 요청할 경우
                        {
                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);
                            sendPacket.respondType = respondType.Start;
                            sendPacket.IsHost = false;
                            Send(sendPacket);
                        }
                        else
                        {
                            // DB에서 모두 레디했는지 확인
                            bool suc = Database.checkUsersReady(roomId: p.room.roomId);

                            if (suc)
                            {
                                Database.startGame(roomId: p.room.roomId);

                                List<string> img = new List<string>();


                                // 쓰레드로 돌려야 할거 같다.
                                // 테스트를 위한 코드
                                string img1 = "https://pbs.twimg.com/media/Fb_Sec8WQAIbCZV?format=jpg&name=medium";
                                string img2 = "https://i.ytimg.com/vi/HUNFD3ktkQ4/maxresdefault.jpg";
                                string img3 = "https://i.ytimg.com/vi/K0TW-zcbEuY/mqdefault.jpg";
                                string img4 = "https://pbs.twimg.com/media/Fb_Sec8WQAIbCZV?format=jpg&name=medium";
                                string img5 = "https://i.ytimg.com/vi/HUNFD3ktkQ4/maxresdefault.jpg";
                                img.Add(img1);
                                img.Add(img2);
                                img.Add(img3);
                                img.Add(img4);
                                img.Add(img5);
                                AnsList = new List<List<string>>(10);
                                SendAnsList = new List<string> { "0", "0", "0", "0", "0", "0", "0" };

                                // 이미 만든 경우 확인
                                if (!Database.CheckQuestion(p.room.roomId) && p.room.userId == p.user.userId)
                                {
                                    for (int i = 1; i <= 5; i++)
                                    {
                                        // ! 단어 조합 필요
                                        List<string> tmp = new List<string> { "apple", "banna", "candy", "qq", "ww", "ee" };
                                        AnsList.Add(tmp);
                                        Database.makeQuestion(p.room.roomId, i, img[i - 1], AnsList[i - 1]);
                                    }
                                }


                                // 게임 실행하게 되면 레코드 테이블에 유저 등록
                                // 이미 등록되어있는지 확인

                                foreach(User curUser in p.room.userList)
                                {
                                    if (!Database.registerRecordCheck(curUser.userId, p.room.roomId))
                                        Database.registerRecordTable(curUser.userId, p.room.roomId);
                                }

                               


                                p.room.Question = img[0];
                                InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                               
                                sendPacket.respondType = respondType.Start;  // 오직 여기서만 Start 패킷 보내야 함
                                sendPacket.IsHost = true;
                                sendPacket.start = true;
                                sendPacket.room.round = 1;

                                foreach (User user in p.room.userList)
                                {
                                    Program.clientList[user.userId].Send(sendPacket);
                                }

                            }
                            else  // 모두 레디 x 인 경우
                            {
                                InGamePacket sendPacket = new InGamePacket(p.user, p.room);
                                sendPacket.respondType = respondType.Start;
                                sendPacket.IsHost = true;
                                sendPacket.start = false;
                                Send(sendPacket);
                            }
                        }
                    }
                    else if (p.respondType == respondType.Answer)
                    {
                      
                        string tmpAns = p.Answer;

                        // DB에 해당 룸에 라운드에 정답 물어보기
                        int idx = Database.checkAnswer(userId: p.user.userId, roomId: p.room.roomId, round: p.room.round, userAnswer: p.Answer);

                        InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                        sendPacket.respondType = respondType.Answer;
                        sendPacket.Answer = tmpAns;
                        sendPacket.correct = idx;

                        if(idx == 0)  // 오답인 경우
                        {
                            Send(sendPacket);
                        }
                        else   // 정답인 경우
                        {

                            foreach(User user in p.room.userList)
                            {
                                Program.clientList[user.userId].Send(sendPacket);
                            }
                           
                        }

                    }
                    else if (p.respondType == respondType.NextGame)  // 다음 라운드 진행
                    {
                        // 해당 게임의 모든 라운드가 끝났는지 확인, 일단 5 라운드 상수로 지정

                        p.room.round = Database.updateRound(p.room.roomId);

                        if (p.room.round == 6)  // 해당 게임의 모든 라운드가 끝남을 의미
                        {
                            // round 초기화
                            Database.initRound(p.room.roomId);

                            // now playing 수정
                            Database.initNowPlaying(p.room.roomId);

                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);
                            sendPacket.Type = PacketType.InGame;
                            sendPacket.respondType = respondType.End;

                            // DB에서 해당 게임의 결과 가져오기
                            List<Records> records = Database.getRecordEveryone( roomId: p.room.roomId);
                            sendPacket.records = records;


                            foreach(User curUser in p.room.userList)
                            {
                                // 유저 정보 업데이트
                                sendPacket.user = Database.getRecords(curUser.userId);

                                // 유저 레디 해제
                                Database.readyCancel(curUser.userId, p.room.roomId);

                                p.user.ready = false;

                                Program.clientList[curUser.userId].Send(sendPacket);
                            }

                        }
                        else
                        {

                            // Dall-e와 통신 or Dall-e DB 접근 -> 달리 이미지랑 단어 조합 받아오기
                            //
                            //


                            SendAnsList.Clear();
                            // 현재 라운드에 맞는 문제 찾기
                            string img = Database.getQuestion(p.room.roomId, p.room.round);
                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                            sendPacket.Type = PacketType.InGame;
                            sendPacket.room.Question = img;
                            sendPacket.respondType = respondType.Start;  // 다시 시작을 의미

                            sendPacket.IsHost = true;
                            sendPacket.start = true;

                            foreach (User user in p.room.userList)
                            {
                                Program.clientList[user.userId].Send(sendPacket);
                            }

                            
                        }

                    }
                    else if (p.respondType == respondType.End)
                    {
                        Database.readyCancel(p.user.userId, p.room.roomId);
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

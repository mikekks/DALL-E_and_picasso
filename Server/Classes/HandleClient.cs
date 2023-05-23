﻿using System;
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

        public List<string> AnswerList;

        public static Dictionary<int, Room> roomList;


        ////////////// 테스트를 위한 임시 변수들 //////////////
        
        int Round = 2;  // 남은 라운드 의미
        bool flipflop = true;
        public static int readyChk = 0;

        ////////////// 테스트를 위한 임시 변수들 //////////////


        public HandleClient(TcpClient client)
        {
            this.client = client;
            stream = client.GetStream();

            roomList = new Dictionary<int, Room>();
            

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
                    //
                    //

                    user = new User(p.user.userId, p.user.password, "Song min gyu", 100, 70, 30, 70, "Gold");

                    if (true)  // 로그인 성공 경우
                    {   

                        // rooms 정보 db에서 불러오기 for문으로 저장
                        //
                        //

                        Room newRoom = new Room(1, 3, "고수만", 3, 1, 0);
                        newRoom.userList = new List<User>();
                        newRoom.userList.Add(user);
                        newRoom.Host = user;
                        roomList.Add(newRoom.roomID, newRoom);  // for문으로 저장
                        
                        p = new LoginPacket(true, user, roomList);
                        Send(p);
                    }
                    else  // 로그인 실패 경우
                    {
                        p = new LoginPacket(false, user, null);  // ! null로 해도 되나?
                        Send(p);
                    }



                }
                else if (packet.Type == PacketType.Register)
                {
                    RegisterPacket p = packet as RegisterPacket;
                    
                    if(p.registerType == RegisterType.duplicate)
                    {
                        // DB에서 해당 아이디(p.id) 중복도 검사
                        //
                        //
                        bool test = true;
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
                        //  db에 해당 유저의 정보(p에 다 들어있음) 저장
                        //
                        //

                        bool test = true;  // 테스트를 위함
                        RegisterPacket sendPacket;
                        if (test)  // 회원가입 성공
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
                        //
                        //

                        bool test = true;  // 테스트를 위함

                        if (test)  // 새로운 방 생성 성공
                        {
                            Room room = new Room(p.room.roomID, p.room.level, p.room.roomName, p.room.TotalNum, 1, 0);
                            room.Host = p.user;

                            RoomPacket sendPacket = new RoomPacket(room, RoomType.New);
                            sendPacket.Type = PacketType.RoomCreate;
                            room.userList = new List<User> { p.user };
                            room.ReadyList = new Dictionary<int, bool>
                            {
                                 { p.user.userId, false }
                            };
                            sendPacket.userList = room.userList;
                            sendPacket.ReadyList = room.ReadyList;
                            sendPacket.room.Host = p.user;

                            sendPacket.roomType = p.roomType;
                            sendPacket.room.create = true;

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
                        // db에서 요청하는 방과 중복되는게 있는지 확인
                        // 
                        //

                        // db에 해당 방 생성
                        //
                        //

                        bool test = true;  // 테스트를 위함

                        if (test)  // 새로운 방 생성 성공
                        {
                            Room room = new Room(p.room.roomID, p.room.level, p.room.roomName, p.room.TotalNum, 1, 0);
                            room.Host = p.user;

                            RoomPacket sendPacket = new RoomPacket(room, RoomType.New);
                            sendPacket.Type = PacketType.Room;
                            sendPacket.userList = p.userList;
                            sendPacket.ReadyList = p.ReadyList;
                            sendPacket.roomType = p.roomType;
                            sendPacket.room.create = true;

                            Send(sendPacket);

                        }
                        else  // 방 생성 실패
                        {
                            RoomPacket sendPacket = new RoomPacket(null, RoomType.New);
                            sendPacket.Type = PacketType.Room;
                            sendPacket.roomType = p.roomType;
                            Send(sendPacket);
                        }
                    }
                    */
                    if (p.roomType == RoomType.Enter)
                    {
                        // p.room.roomID로 해당 룸을 DB에서 쿼리
                        // room type으로 반환
                        //
                        Room _room = new Room(1,3,"고수만",3,1,0);
                        _room.userList = new List<User>();
                        _room.ReadyList = new Dictionary<int, bool>();
                        
                        if(_room.TotalNum - _room.PartyNum > 0)  // 입장 가능을 의미
                        {
                            // p.room.roomID로 해당 룸을 DB에서 쿼리해서 PartyNum 1 증가(수정)시킨다.
                            // 유저 리스트에  p.room.userList[?] 를 추가시킨다.
                            //

                            _room.userList.Add(p.room.userList[0]);
                            _room.ReadyList.Add(p.room.userList[0].userId, false);
                            _room.PartyNum++;
                            _room.Host = user;
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
                        //
                        //
                        bool test = true;  // 테스트를 위한 변수
                        readyChk++;  // 테스트를 위한 변수

                        if (p.ready && test)  // 방금 레디한 경우 : db에는 ready x,  하지만 패킷에는 Ready = true
                        { 
                            // db에 해당 방의 해당 유저를 레디 상태로 수정
                            // 그 후 다시 해당 방의 유저리스트 쿼리
                            //

                            p.room.ReadyList[p.user.userId] = true;
                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);
                            sendPacket.Type = PacketType.InGame;
                            sendPacket.respondType = respondType.Ready;
                            sendPacket.ready = true;
                            Send(sendPacket);
                            
                        }
                        else { // 예전에 레디한 경우 or 레디하지 않은 경우
                            // 해당 방의 유저리스트 쿼리
                        }


                    }
                    else if (p.respondType == respondType.Start)
                    {
                        // DB에서 방장인지 확인(이 부분은 보류), 모두 레디했는지 확인  : p.room.roomID, p.user.userId 사용
                        //
                        //

                        bool test = true;
                        if (test && readyChk == 2)  // 두 경우 모두 통과한 경우
                        {
                            // 일단 현재 구현은 단일 라운드로 진행
                            string img = "https://pbs.twimg.com/media/Fb_Sec8WQAIbCZV?format=jpg&name=medium";
                            // 식별번호?, Dalle image, 정답 단어, 해당 room 저장
                            //
                            //

                            p.room.Question = img;
                            InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                            sendPacket.Type = PacketType.InGame;
                            sendPacket.respondType = respondType.Start;  // 오직 여기서만 Start 패킷 보내야 함
                            sendPacket.ready = true;
                            Send(sendPacket);
                        }
                        else  // 하나라도 통과 안된 경우
                        {

                        }

                    }
                    else if (p.respondType == respondType.Answer)
                    {
                        string tmpAns = p.Answer;

                        if(AnswerList == null)
                            AnswerList = new List<string>();
                        // DB에서 해당 룸( p.room.roomID ) 에 
                        // 매핑되는 문제의 정답 단어 불러오기
                        //

                        if (AnswerList.Count < 3)
                        {  // ! 여기는 일단 하드코딩
                            AnswerList.Add("Apple");
                            AnswerList.Add("Banana");
                            AnswerList.Add("Candy");
                        }
                        
                        InGamePacket sendPacket = new InGamePacket(p.user, p.room);

                        sendPacket.Type = PacketType.InGame;
                        sendPacket.respondType = respondType.Answer;
                        sendPacket.Answer = tmpAns;

                        int check = 0;
                        int idx;

                        for(idx=1; idx<=AnswerList.Count; idx++) 
                        {
                            if (AnswerList[idx-1] == tmpAns)  // 정답인 경우
                            {
                                check = idx;
                            }
                        }
                        sendPacket.correct = check;                    

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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
       
        public static Dictionary<int, Room> roomList;
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

                        Room newRoom = new Room(1, 1, "고수만", 3, 1, 0);
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

                }
                else if (packet.Type == PacketType.Room)
                {
                    RoomPacket p = packet as RoomPacket;

                    if(p.roomType == RoomType.New)
                    {

                    }
                    else if (p.roomType == RoomType.Enter)
                    {
                        // p.room.roomID로 해당 룸을 DB에서 쿼리
                        // room type으로 반환
                        //
                        Room _room = new Room(1,1,"고수만",3,1,0);
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
                        bool test = true;
                        if (test) {  
                            // 방금 레디한 경우 
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
                        else if (!test) { // 예전에 레디한 경우
                            // 해당 방의 유저리스트 쿼리
                        }


                    }
                    else if (p.respondType == respondType.Answer)
                    {

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

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
       
        public static Dictionary<string, Room> roomList;
        public HandleClient(TcpClient client)
        {
            this.client = client;
            stream = client.GetStream();

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
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
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

                    if (true)
                    {   // 로그인 성공 경우

                        // rooms 정보 db에서 불러오기
                        //
                        //

                        p = new LoginPacket(true, user, roomList);
                        Send(p);
                    }
                    else
                    {
                        p.success = false;
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
                    else if (p.roomType == RoomType.New)
                    {

                    }
                }
                else if (packet.Type == PacketType.InGame)
                {
                    InGamePacket p = packet as InGamePacket;
                    if(p.respondType == respondType.Ready)
                    {

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

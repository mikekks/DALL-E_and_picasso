using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using DalleLib;
using DalleLib.InGame;
using System.Threading;
using DalleLib.Networks;
using System.Text;

namespace Client
{
    public enum loginType
    {
        nope, success, fail
    }

    internal static class Program
    {

        public static TcpClient clientSocket;
        public static NetworkStream stream;
        public const ushort port = 9999;
        public static Thread t_Recieve;

        public static User user; // 로그인한 유저에 대한 정보
        public static Room room; // 유저가 현재 있는 방

        public static Dictionary<string, Room> roomList;  // 유저가 보는 방리스트
        public static bool isHost;

        public static Dictionary<PacketType, Action<Packet>> MethodList;

        public static object LOCK = new object();

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            clientSocket = new TcpClient();

            t_Recieve = new Thread(Recieve);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            // ! clientSocket.Connected ?


        }

        static void Recieve()
        {
            byte[] readBuffer = null;
            byte[] Length_buffer = new byte[4];


            while (clientSocket.Connected)
            {
                try
                {
                    // 패킷길이 통일하면 안된다. db관련 정보는 너무 크기 때문에
                    // 그 크기에 맞춰 패킷 길이를 정하면 부하가 너무 심해진다.


                    stream.Read(Length_buffer, 0, 4);  // ! 패킷길이 예외처리가 필요한가?
                    readBuffer = new byte[BitConverter.ToInt32(Length_buffer, 0)];

                    int size = BitConverter.ToInt32(Length_buffer, 0);
                    stream.Read(readBuffer, 0, size);  // ! 패킷이 중간에 잘리나?

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    break;
                }

                object Objpacket = null;
                Objpacket = Packet.Deserialize(readBuffer);

                Packet packet = Objpacket as Packet;

                MethodList[packet.Type].Invoke(packet);

                //  packet.Type에 따라 처리 작업 필요.
                /*
                if (packet.Type == PacketType.Login)
                {
                    LoginPacket p = packet as LoginPacket;

                    MethodList[PacketType.Login].Invoke(p);
                    
                    
                }
                else if (packet.Type == PacketType.Register)
                {

                }
                else if(packet.Type == PacketType.InGame)
                {
                    
                }
                else if (packet.Type == PacketType.Room)
                {
                    RoomPacket p = packet as RoomPacket;

                    MethodList[PacketType.Login].Invoke(p);
                    
                   
                    
                }
                */
            }

        }

        public static void Send(Packet packet)
        {
            lock (LOCK)
            {
                byte[] sendBuffer = packet.Serialize();
                byte[] Buffer_length = BitConverter.GetBytes(sendBuffer.Length);

                stream.Write(Buffer_length, 0, 4);
                stream.Write(sendBuffer, 0, sendBuffer.Length);
                stream.Flush();
            }
        }
    }
}

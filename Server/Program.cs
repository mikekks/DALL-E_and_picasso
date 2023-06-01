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
        public static int[] AnsList_note = new int[7];

        public static List<HandleClient> unloginClientList;
        public static Dictionary<string, HandleClient> clientList;

        static void Main(string[] args)
        {

            unloginClientList = new List<HandleClient>();
            clientList = new Dictionary<string, HandleClient>();

            /// 데이터베이스 접속
            if (Database.connect()) 
            {

            }
            else
            {
                Console.WriteLine("DB 접속 실패");
            }
            


            server = new TcpListener(IPAddress.Any, port);
            
            server.Start();

            while (true)
            {
                HandleClient h_client = new HandleClient(server.AcceptTcpClient());

                Console.WriteLine("client connect!");

            }
        }

        public static bool loginClient(HandleClient client)
        {
            if(client.user.userId == null)
            {
                Console.WriteLine("id가 0 오류");
                return false;
            }

            if(clientList.ContainsKey(client.user.userId))
            {
                Console.WriteLine("이미 clientList에 존재 ");
                return false;
            }

            clientList.Add(client.user.userId, client);
            unloginClientList.Remove(client);
            return true;
        } 
    }
}
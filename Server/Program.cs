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

        static void Main(string[] args)
        {
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
    }
}
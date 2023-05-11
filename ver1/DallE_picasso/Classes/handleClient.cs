using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Net.Http;
using Newtonsoft.Json;

using Newtonsoft.Json.Linq;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DallE_picasso
{

    internal class handleClient
    {
        TcpClient clientSocket;
        int clientNo;

        static int partyCount;
        static int ReadyCount;  // 공유 변수
        static string img;

        static object lockObj = new object();

        private static HttpClient sharedClient = new HttpClient()
        {
            BaseAddress = new Uri("https://api.openai.com/"),
        };

        static async Task<string> PostAsync(HttpClient httpClient)
        {
            // 조합을 요청하고자 하는 텍스트를 prompt의 value에 넣어주시면 됩니다. 
            using (StringContent jsonContent = new StringContent(
                Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    model = "image-alpha-001",
                    prompt = "a cup of coffee with a smiley face",
                    num_images = 1,
                    size = "1024x1024",
                    response_format = "url"
                }),
                Encoding.UTF8,
                "application/json"))
            {
                // 개인 API 키 입니다.
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer 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");

                using (HttpResponseMessage response = await httpClient.PostAsync(
                    "v1/images/generations",
                    jsonContent))
                {
                    response.EnsureSuccessStatusCode();
                    //WriteRequestToConsole(response);

                    var responseJson = JObject.Parse(await response.Content.ReadAsStringAsync());
                    var url = responseJson["data"][0]["url"].ToString();

                    Console.WriteLine($"--- PostAsync ---");
                    Console.WriteLine($"{url}\n");

                    return url;
                }
            }
        }


        public void startClient(TcpClient ClientSocket, int clientNo)
        {
            this.clientSocket = ClientSocket;
            this.clientNo = clientNo;
            partyCount = clientNo;

            Thread t_hanlder = new Thread(doChat);  // 클라이언트마다 소통할 쓰레드 생성
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
            
        }

        public delegate void MessageDisplayHandler(string text);
        public event MessageDisplayHandler OnReceived;

        public delegate void CalculateClientCounter();
        public event CalculateClientCounter OnCalculated;

        private async void doChat()
        {
            NetworkStream stream = null;
            try
            {
                byte[] buffer = new byte[1024];
                string msg = string.Empty;
                int bytes = 0;
                int MessageCount = 0;

                while (true)
                {
                    MessageCount++;
                    stream = clientSocket.GetStream();  // 클라이언트 스트림 가져오기
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                    msg = msg.Substring(0, msg.IndexOf("$"));


                    // 패킷에 따라 분류작업 필요

                    if(msg == "Ready")
                    {
                        /// 모두 ready 전까지 wait, 모두 ready하면 모든 쓰레드가 wait에서 깨어나서 url를 보내준다.
                        PlusReadyCounter();

                      
                        if (ReadyCount != partyCount)
                        {
                            lock (lockObj)
                            {
                                if (ReadyCount != partyCount)
                                {
                                    Monitor.Wait(lockObj);
                                }
                            }
                        }
                        else
                        {
                            img = await PostAsync(sharedClient);
                            lock (lockObj){
                                for(int i=0; i<partyCount; i++)
                                    Monitor.Pulse(lockObj);
                            }
                        }
                     

                        byte[] sbuffer = Encoding.Unicode.GetBytes(img);
                        stream.Write(sbuffer, 0, sbuffer.Length);
                        stream.Flush();

                    }
                    else
                    {
                        msg = "Data Received : " + msg;

                        if (OnReceived != null)
                            OnReceived(msg);

                        msg = "Server to client(" + clientNo.ToString() + ") " + MessageCount.ToString();
                        if (OnReceived != null)
                            OnReceived(msg);

                        byte[] sbuffer = Encoding.Unicode.GetBytes(msg);
                        stream.Write(sbuffer, 0, sbuffer.Length);
                        stream.Flush();

                        msg = " >> " + msg;
                        if (OnReceived != null)
                        {
                            OnReceived(msg);
                            OnReceived("");
                        }
                    }
                    
                }
            }
            catch (SocketException se)
            {
                Trace.WriteLine(string.Format("doChat - SocketException : {0}", se.Message));

                if (clientSocket != null)
                {
                    clientSocket.Close();
                    stream.Close();
                }

                if (OnCalculated != null)
                    OnCalculated();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(string.Format("doChat - Exception : {0}", ex.Message));

                if (clientSocket != null)
                {
                    clientSocket.Close();
                    stream.Close();
                }

                if (OnCalculated != null)
                    OnCalculated();
            }
        }

        private void PlusReadyCounter()
        {
            lock (this)
            {
                if(ReadyCount == 0)
                {
                    


                    img = "https://blog.kakaocdn.net/dn/0mySg/btqCUccOGVk/nQ68nZiNKoIEGNJkooELF1/img.jpg";
                }
                ReadyCount++;
            }
        }

        private void checkReady()
        {

            if (ReadyCount != partyCount)
            {
                lock (this)
                {
                    Monitor.Wait(this);
                }
            }
            else
            {
                lock (this)
                {
                    Monitor.Pulse(this);
                }
            }
        }
    }
}

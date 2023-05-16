class handleClient
{
    TcpClient clientSocket;
    int clientNo;
 
    public void startClient(TcpClient ClientSocket, int clientNo)
    {
        this.clientSocket = ClientSocket;
        this.clientNo = clientNo;
 
        Thread t_hanlder = new Thread(doChat);  // 클라이언트마다 소통할 쓰레드 생성
        t_hanlder.IsBackground = true;
        t_hanlder.Start();
    }
 
    public delegate void MessageDisplayHandler(string text);
    public event MessageDisplayHandler OnReceived;
 
    public delegate void CalculateClientCounter();
    public event CalculateClientCounter OnCalculated;
 
    private void doChat()
    {
        NetworkStream stream = null;
        try
        { 
            byte[] buffer = new byte[1024];
            string msg = string.Empty;
            int bytes = 0;
            int MessageCount = 0;                
 
            while(true)
            {
                MessageCount++;
                stream = clientSocket.GetStream();  // 클라이언트 스트림 가져오기
                bytes = stream.Read(buffer, 0, buffer.Length);
                msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                msg = msg.Substring(0, msg.IndexOf("$"));
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
                if (OnReceived != null) { 
                    OnReceived(msg);
                    OnReceived("");
                }
            }
        }
        catch(SocketException se)
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
}

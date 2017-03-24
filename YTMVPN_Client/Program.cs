using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace YTMVPN_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            byte[] buffer = new byte[233];
            EndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 52145);

            while (true)
            {
                clientSocket.SendTo(buffer, remoteEP);
                Thread.Sleep(1000);
            }


        }
    }
}
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
            //初始化Socket
            Socket authSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Socket dataSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //认证
            byte[] authBuffer = new byte[1];  //测试认证 将会忽略
            EndPoint authServerEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 52146);


            //数据
            byte[] dataBuffer = new byte[6];  //测试数据 2地址 2端口 2数据
            EndPoint dataServerEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 52146);

            while (true)
            {

                authSocket.SendTo(authBuffer, authServerEP);
                dataSocket.SendTo(dataBuffer, dataServerEP);
                Thread.Sleep(1000);
            }


        }
    }
}
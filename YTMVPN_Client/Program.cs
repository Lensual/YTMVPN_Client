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
            EndPoint authServerEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 52145);


            //数据
            byte[] dataBuffer = new byte[6] { 0xFF, 0x00, 0xFF, 0x00, 0xAB, 0xCD };  //测试数据 目标地址 源地址 目标端口 源端口 2Byte数据
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
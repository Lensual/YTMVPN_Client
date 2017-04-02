using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using YTMVPN_Server;

namespace YTMVPN_Client
{
    class Program
    {
        //static Socket dataSocket;
        static void Main(string[] args)
        {
            //设置控制台输出为UTF8
            Console.OutputEncoding = Encoding.UTF8;

            //参数和配置文件的解析 先不写了，参数写死先
            Config.IP_Address = "127.0.0.1";
            Config.IP_AuthPort = 52145;
            Config.IP_DataPort = 52146;

            Config.Logic_AddrLength = 1;
            Config.Logic_PortLength = 1;
            Config.Logic_LocalAddr = new byte[1] { 0x00 };



















        //    //初始化Socket
        //    Socket authSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        //    Socket dataSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        //    dataSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 50000));


        //    //认证
        //    byte[] authBuffer = new byte[1];  //测试认证 将会忽略
        //    EndPoint authServerEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 52145);


        //    //数据
        //    byte[] dataBuffer = new byte[6] { 0xFF, 0x00, 0xFF, 0x00, 0xAB, 0xCD };  //测试数据 目标地址 源地址 目标端口 源端口 2Byte数据
        //    EndPoint dataServerEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 52146);

        //    Program.dataSocket = dataSocket;
        //    Thread t = new Thread(recv);
        //    t.IsBackground = true;
        //    t.Start();

        //    while (true)
        //    {

        //        authSocket.SendTo(authBuffer, authServerEP);
        //        dataSocket.SendTo(dataBuffer, dataServerEP);
        //        Thread.Sleep(1000);
        //    }


        //}

        //static void recv(object state)
        //{
        //    while (true)
        //    {
        //        byte[] buffer = new byte[4096];
        //        EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
        //        dataSocket.ReceiveFrom(buffer, ref remoteEP);
        //    }
        //}
    }
}
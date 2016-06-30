﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace SocketServer
{
    class Program
    {
        private static byte[] result = new byte[1024];
        private static byte[] btsend;
        private static int myProt = 8885;   //端口  
        static Socket serverSocket;
        static void Main(string[] args)
        {
            //服务器IP地址  
            IPAddress ip = IPAddress.Parse(mymean.ip);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(ip, myProt));  //绑定IP地址：端口  
            serverSocket.Listen(10);    //设定最多10个排队连接请求  
            Console.WriteLine("启动监听{0}成功", serverSocket.LocalEndPoint.ToString());
            //通过Clientsoket发送数据  
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
            Console.ReadLine();
        }

        /// <summary>  
        /// 监听客户端连接  
        /// </summary>  
       private static void ListenClientConnect()
        {
           byte[] btsend = mymean.DataToByte(mymean.sqlreturndatasetselect("select * from student"));
            //mymean.getrturnsqlconn("select * from student where sname='王明'"); 
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                try
                {   
                    
                    clientSocket.Send(btsend,btsend.Length,0);
                }
                catch (Exception)
                {
                    Console.WriteLine("失败");
                   
                }
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
                receiveThread.Abort();
                Console.WriteLine("threadstop");

            }
        }

        /// <summary>  
        /// 接收消息  
        /// </summary>  
        /// <param name="clientSocket"></param>  
        private static void ReceiveMessage(object clientSocket)
        {
            Socket myClientSocket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据  
                    int receiveNumber = myClientSocket.Receive(result);
                    Console.WriteLine("接收客户端{0}消息{1}", myClientSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, receiveNumber));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;
                }
            }
        }

        public static IList<ArraySegment<byte>> sends { get; set; }

        public static System.Collections.Generic.IList<ArraySegment<byte>> sends1 { get; set; }
    }
}
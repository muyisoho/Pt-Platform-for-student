using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using SocketServer;


namespace findtool
{
    class servercliention
    {
        public static byte[] result = new byte[102400];
        public static DataSet ds = null;
        public static string clientsql;
        public static int receiveLength = 0;
        public static void cliention()
        {
            IPAddress ip = IPAddress.Parse(mymean.ip);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 8885)); //配置服务器IP与端口  
                Console.WriteLine("连接服务器成功");
            }
            catch
            {
                Console.WriteLine("连接服务器失败，请按回车键退出！");
                return;
            }
            clientSocket.Send(Encoding.UTF8.GetBytes(clientsql));
             receiveLength = clientSocket.Receive(result);
            clientSocket.Close();
        }
    }
}

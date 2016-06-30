using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;

namespace SocketServer
{
    class mymean
    {
        public static string str = "server=.;database=studentfindjob;uid=frank;pwd=ludongdaxue";
        public static SqlConnection mycon;
        public static SqlCommand mymy=null;
        public static string ip = "127.0.0.1";
        public static SqlConnection getcon()//连接数据库
        {
            mycon = new SqlConnection(str);
            mycon.Open();
            return mycon;
        }
        public static void conclose()//关闭数据库
        {
            if(mycon.State==ConnectionState.Closed)
            {
                mycon.Close();
                mycon.Dispose();
            }
        }
        public static byte[]  getsqlcom(string sqlstr)//sql修改,更新
        {
            int i = 0;
            getcon();
            SqlCommand sqlcom = new SqlCommand(sqlstr, mycon);
           i=Convert.ToInt32 (sqlcom.ExecuteNonQuery());
            sqlcom.Dispose();
            conclose();
            if (i != 0)
                return Encoding.UTF8.GetBytes("@");
            else
                return Encoding.UTF8.GetBytes("*"); 
        }
        public static byte[] getrturnsqlconn(string sqlstr)//sql查询返回结果
        {
            int i = 0;
            string makeup = null, makeup1 = null, makeup2 = null;
            SqlConnection mycon1 = getcon();
            SqlCommand sqlcom = new SqlCommand(sqlstr, mycon1);
            //SqlCommand sqlcom = new SqlCommand();
            //sqlcom.Connection = mycon1;
           // sqlcom.CommandText = sqlstr;
           // sqlcom.CommandType = CommandType.Text;
            SqlDataReader sdr = sqlcom.ExecuteReader();
            while (sdr.Read())
            {
                for (i = 0; i < sdr.FieldCount; i++)
                {
                    makeup1 = sdr[i].ToString().Trim();

                    makeup = makeup + makeup1 + "#";

                }
            }
                makeup2 = makeup;
                sqlcom.Dispose();
                conclose();
                return Encoding.UTF8.GetBytes(makeup2);
            }
        public static void unpack(string sqlcon)//解包收到的字符串
        {
            
            string[] scend;
            char[] sp = { '#' };
            scend = sqlcon.Split(sp);
           foreach(string m in scend)
            {
                Console.WriteLine(m); 
            }
            Console.ReadLine();
        }
        public static DataSet sqlreturndatasetselect(string sql)//更新数据
        {
            DataSet ds=new DataSet();
            SqlDataAdapter sda=new SqlDataAdapter();
            SqlConnection mycon = getcon();
            SqlCommand sqlcom = new SqlCommand(sql, mycon);
            sda.SelectCommand = sqlcom;
            sda.Fill(ds, "cs");
            sqlcom.Dispose();
            conclose();
            return ds;
        }
        public static byte[] GetBinaryFormatDataSet(DataSet ds)//dataset序列化
        {
            //创建内存流
            MemoryStream memStream = new MemoryStream();
            //产生二进制序列化格式
            IFormatter formatter = new BinaryFormatter();
            //指定DataSet串行化格式是二进制
            ds.RemotingFormat = SerializationFormat.Binary;
            //串行化到内存中
            formatter.Serialize(memStream, ds);
            //将DataSet转化成byte[]
            byte[] binaryResult = memStream.ToArray();
            //清空和释放内存流
            memStream.Close();
            memStream.Dispose();
            return binaryResult;
        }
        public static DataSet RetrieveDataSet(byte[] binaryData)//dataset范例化
        {
            //创建内存流
            MemoryStream memStream = new MemoryStream(binaryData);
            memStream.Seek(0, SeekOrigin.Begin);
            //产生二进制序列化格式
            IFormatter formatter = new BinaryFormatter();
            //反串行化到内存中
            object obj = formatter.Deserialize(memStream);
            //类型检验
            if (obj is DataSet)
            {
                DataSet dataSetResult = (DataSet)obj;
                return dataSetResult;
            }
            else
            {
                return null;
            }
        }
        public static byte[] DataToByte(DataSet ds)//序列化
        {
            byte[] bArrayResult = null;
            ds.RemotingFormat = SerializationFormat.Binary;
            MemoryStream ms = new MemoryStream();
            IFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, ds);
            bArrayResult = ms.ToArray();
            ms.Close();
            ms.Dispose();
           return bArrayResult;

        }
        public static DataSet ByteToDataset(byte[] bArrayResult)//反序列化
        {
            DataSet dsResult = null;
            MemoryStream ms = new MemoryStream(bArrayResult);
            IFormatter bf = new BinaryFormatter();
            ms.Seek(0, SeekOrigin.Begin);
            object obj = bf.Deserialize(ms);
            dsResult = (DataSet)obj;
            ms.Close();
            ms.Dispose();
            return dsResult;
        } 
    }
}

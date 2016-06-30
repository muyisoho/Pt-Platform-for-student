using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 

namespace SocketServer
{
    class mymean
    {
        public static string str = "server=.;database=studentfindjob;uid=frank;pwd=ludongdaxue";
        public static SqlConnection mycon;
        public static SqlCommand mymy;
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
                return Encoding.ASCII.GetBytes("@");
            else
                return Encoding.ASCII.GetBytes("*"); 
        }
        public static byte[] getrturnsqlconn(string sqlstr)//sql查询返回结果
        {
            int i=0;
            string makeup = null,makeup1=null,makeup2=null;
            SqlConnection mycon1= getcon();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = mycon1;
            sqlcom.CommandText = sqlstr;
            sqlcom.CommandType = CommandType.Text;
            SqlDataReader sdr = sqlcom.ExecuteReader();
            while (sdr.Read())
            {
                makeup1 = sdr[i].ToString();
                i++;
                makeup = makeup + makeup1 + "#";

            }
            makeup2 = makeup;
            sqlcom.Dispose();
            conclose();
            return Encoding.ASCII.GetBytes(makeup2);
        }

    }
}

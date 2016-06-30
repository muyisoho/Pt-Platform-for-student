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
        public void conclose()//关闭数据库
        {
            if(mycon.State==ConnectionState.Closed)
            {
                mycon.Close();
                mycon.Dispose();
            }
        }
        public void getsqlcom(string sqlstr)//查询sql修改，删除，查询语句
        {
            getcon();
            SqlCommand sqlcom = new SqlCommand(sqlstr, mycon);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            conclose();
        }
        public SqlCommand getrturnsqlconn(string sqlstr)
        {
            getcon();
            SqlCommand sqlcom = new SqlCommand(sqlstr, mycon);
            sqlcom.Dispose();
            conclose();
            return sqlcom;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SocketServer;
using  findtool;

namespace o
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void register1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if ((loginNumtxt.Text.Trim() != "" && loginPasstxt.Text.Trim() != ""))  //
            {

                servercliention.clientsql = "2#"+"select * from student where sname='" + loginNumtxt.Text.Trim() + "'and spassword='" + loginPasstxt.Text.Trim() + "'";
                servercliention.cliention();
                string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
                if (sqlsend.CompareTo("查询成功") == 0)
                {
                    o.user.login_name = loginNumtxt.Text;
                    this.Hide();
                    //firstPage fp = new firstPage();
                   // fp.Show();
                }
                else
                {
                    MessageBox.Show("数据表中没有值");
                }
            }


            else
                MessageBox.Show("信息不完整，登录失败！");
        }
    }
}

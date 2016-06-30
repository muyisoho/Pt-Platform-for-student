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
using findtool;

namespace o
{
    public partial class changePass : Form
    {
        public changePass()
        {
            InitializeComponent();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            personPage pp = new personPage();
            pp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("提示：输入旧密码！", "警告");
            }
            else
            {
                if (textBox3.Text.Trim() == "")
                {
                    MessageBox.Show("提示：输入新密码！", "警告");
                }
                else
                {
                    servercliention.clientsql ="2#"+ "select * from student where sname='王明'and spassword='" + textBox1.Text.Trim() + "'";
                    servercliention.cliention();
                    string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);


                    if (sqlsend.CompareTo("查询成功") == 0)
                    {
                        servercliention.clientsql = "3#" + "update student set spassword='" + textBox3.Text.Trim() + "' where sname='王明'";
                        servercliention.cliention();
                        string sqlsend1= Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);

                        if (sqlsend1.CompareTo("修改成功！") == 0)
                        {
                            MessageBox.Show("提示：密码修改成功！", "提示");
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("提示：旧密码错误！", "警告");
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
          /*  unlogin up1 = new unlogin();
            up1.Show();*/
        }

        private void changePass_Load(object sender, EventArgs e)
        {
            panel14.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (panel14.Visible == false)
            {
                panel14.Visible = true;
            }
            else
            {
                panel14.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

    }
}
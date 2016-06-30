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
    public partial class changePerson : Form
    {
        public changePerson()
        {
            InitializeComponent();
        }

        private void changePerson_Load(object sender, EventArgs e)
        {
            panel14.Visible = false;
            servercliention.clientsql = "1#" + "select * from student where sname='" + o.user.login_name + "'";
            servercliention.cliention();
            string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
            string[] dr = mymean.unpack(sqlsend);                      
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[3].ToString();
                textBox4.Text = dr[4].ToString();
                textBox5.Text = dr[6].ToString();
                textBox6.Text = dr[5].ToString();
                textBox7.Text = dr[11].ToString();
                textBox8.Text = dr[8].ToString();
                textBox9.Text = dr[9].ToString();
                textBox10.Text = dr[10].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
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
                    servercliention.clientsql = "2#" + "select * from student where sname='" + o.user.login_name + "'";
                    servercliention.cliention();
                    string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);                                                        
                    if (sqlsend.CompareTo("查询成功") == 0)
                    {
                      servercliention.clientsql = "3#" + "update student set salary='" + textBox5.Text.Trim() + "',special='" + textBox6.Text.Trim() + "',experimence='" + textBox7.Text.Trim() + "',slanguage='" + textBox8.Text.Trim() + "',telephone='" + textBox9.Text.Trim() + "',email='" + textBox10.Text.Trim() + "',school='" + textBox2.Text.Trim() + "',major='" + textBox3.Text.Trim() + "',saddress='" + textBox4.Text.Trim() + "' where sname='" + o.user.login_name + "'";
                    servercliention.cliention();
                    string sqlsend1 = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength); 
                        if (sqlsend1.CompareTo("修改成功！") == 0)
                        {
                            MessageBox.Show("提示：修改成功！", "提示");
                           // personPage pp = new personPage();
                           // pp.Show();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("提示：错误！", "警告");
                    }
                    


                }
            }


                }

        private void panel14_Paint(object sender, PaintEventArgs e)
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
            this.Hide();
          /*  changePass cp = new changePass();
            cp.Show();*/
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            /* unlogin up = new unlogin();
            up.Show();*/
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
           
        }

       

       

       
    }


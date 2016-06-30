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
    public partial class personPage : Form
    {
        public personPage()
        {
            InitializeComponent();
        }

        private void personPage_Load(object sender, EventArgs e)
        {
            panel14.Visible = false;
            servercliention.clientsql = "select * from student where sname='" + o.user.login_name + "'";
                         servercliention.cliention();
                         string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
                  string[] dr=  mymean.unpack(sqlsend);
                label14.Text = dr[0].ToString();
                label15.Text = dr[2].ToString();
                label16.Text = dr[3].ToString();
                label17.Text = dr[4].ToString();
                label6.Text = dr[6].ToString();
                label7.Text = dr[5].ToString();
                label8.Text = dr[11].ToString();
                label9.Text = dr[8].ToString();
                label12.Text = dr[9].ToString();
                label13.Text = dr[10].ToString();
            
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           /* changePerson cpp = new changePerson();
            cpp.Show();*/
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

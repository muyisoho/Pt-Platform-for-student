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
    public partial class jobInfo : Form
    {
       
        public jobInfo()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void jobInfo_Load(object sender, EventArgs e)
        {

            servercliention.clientsql = "1#" + "select jname,jsalary,jaddress,jdescription,jrequire,jconnection,jtelephone,cname,cindustry,cscale,caddress from job,company where job.id='" + o.user.job_id + "' and cname in (select cname from findjob where id='" + o.user.job_id + "')";
            servercliention.cliention();
            string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
            string[] dr = mymean.unpack(sqlsend);                     
            label14.Text =dr[0]. ToString();
            label9.Text = dr[1].ToString();
            label10.Text = dr[2].ToString();
            label11.Text = dr[3].ToString();
            label12.Text = dr[4].ToString();
            label13.Text = dr[5].ToString() + dr[6].ToString();
            label15.Text = dr[7].ToString();
            label19.Text =dr[8].ToString();
            label20.Text = dr[9].ToString();
            label21.Text = dr[10].ToString();
           user.cname = dr[7].ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)//投递
        {
            if (user.login_name!=null)
            {
                servercliention.clientsql = "3#" + "insert  into findjob(id,cname,sname) values('" + user.job_id + "','" + user.login_name + "','" + user.cname + "');";
                servercliention.cliention();
                string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
                MessageBox.Show("投递成功！");
                this.Hide();
            firstPage fp = new firstPage();
            fp.Show();
    
           }
            else{   
                   MessageBox.Show("请先登录！");
                    this.Hide();
                    log lo=new log();
                    lo.Show();
            }  

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}

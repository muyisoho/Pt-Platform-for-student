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

namespace SocketServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = mymean.mymy.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[3].ToString();
                textBox4.Text = dr[4].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xuliehau myyou = new xuliehau();
            mymean my = new mymean();
            string sqlstr = "select sname,sex,school,major from student where sname='王明'";
            SqlCommand cmsql = my.getrturnsqlconn(sqlstr);
            ESqlCommand esCommand = new ESqlCommand(cmsql);
        }
    }
}

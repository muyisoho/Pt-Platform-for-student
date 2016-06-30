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
            SqlConnection conn = null;
            string ConStr = "server = .;database =employ;uid =sa;pwd =123";
            conn = new SqlConnection(ConStr);
            conn.Open();
            string str = "select * from job where id='" + o.user.job_id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label14.Text = dt.Rows[0][0].ToString();
            label9.Text = dt.Rows[0][3].ToString();
            label10.Text = dt.Rows[0][4].ToString();
            label11.Text = dt.Rows[0][1].ToString();
            label12.Text = dt.Rows[0][2].ToString();
            label13.Text = dt.Rows[0][5].ToString() + dt.Rows[0][6].ToString();
            label15.Text = "小米公司";
            label19.Text = "IT";
            label20.Text = "60~100";
            label21.Text = "烟台市芝罘区";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //SqlConnection conn;
            //string ConStr = "server = .;database =employ;uid =sa;pwd =123";
            //conn = new SqlConnection(ConStr);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from student where sname='" + o.user.login_name + "'", conn);
            //SqlDataReader dr = cmd.ExecuteReader();
           // while (dr.Read()) {   //说明投递人已经登录了
           //     string cmd2 = "insert into findjob values('" + onlineBook.user.book_id + "','" + onlineBook.user.login_name + "')";
           //     SqlCommand com = new SqlCommand(cmd2, conn);
           //     if (com.ExecuteNonQuery() != 0)//com.ExecuteNonQuery()执行语句，并返回受影响行数
           //         MessageBox.Show("投递成功！");
            //          this.hide();
           // firstPage fp = new firstPage();
           // fp.Show();
    
          //  }
           // while(dr.Read()==0){    //说明未登录
                   // MessageBox.Show("请先登录！");
                    //this.Hide();
                   // log lo=new log();
                   // lo.Show();
           // }  

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}

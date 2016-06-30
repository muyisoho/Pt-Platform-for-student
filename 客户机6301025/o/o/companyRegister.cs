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
    public partial class companyRegister : Form
    {
        public companyRegister()
        {
            InitializeComponent();
        }

        private void companyTypetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyNameLab_Click(object sender, EventArgs e)
        {

        }

        private void companyRegBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            if (companyNametxt.Text.Trim() != "" && companyTypetxt.Text.Trim() != "" && companyAddtxt.Text.Trim() != "" && companyPasstxt.Text.Trim() != "" && companyPassAgaintxt.Text.Trim() != "")
            {
                try
                {
                    string ConStr = "server = .;database =employ;uid =sa;pwd =123";
                    conn = new SqlConnection(ConStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        string cmd = "insert into company(cname,caddress,cindustry,cpassword) values('" + companyNametxt.Text + "','" + companyAddtxt.Text + "','" + companyTypetxt.Text + "','" + companyPassAgaintxt.Text + "')";
                        SqlCommand com = new SqlCommand(cmd, conn);
                        if (com.ExecuteNonQuery() != 0)//com.ExecuteNonQuery()执行语句，并返回受影响行数
                            MessageBox.Show("注册成功！");
                        this.Hide();
                        log log2 = new log();
                        log2.Show();
                    }
                    else
                    {
                        MessageBox.Show("注册不成功！");
                        conn.Close();//关闭
                    }

                }

                catch
                {
                    MessageBox.Show("连接数据库失败");
                }
            }
            else
                MessageBox.Show("信息不完整，注册失败！");
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            log lo = new log();
            lo.Show();

        }

        private void studentBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}

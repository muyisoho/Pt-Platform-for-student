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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void employerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            companyRegister cr = new companyRegister();
            cr.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            log log1 = new log();
            log1.Show();
        }

        private void stuRegBtn_Click(object sender, EventArgs e)
        {

            if (stuRegNametxt.Text.Trim() != "" && regSchoolNametxt.Text.Trim() != "" && majortxt.Text.Trim() != "" && addresstxt.Text.Trim() != "" && passtxt.Text.Trim() != "" && passPasstxt.Text.Trim() != "")
            {
               
                    
                        servercliention.clientsql = "3#"+"insert into student(sname,school,major,saddress,spassword) values('" + stuRegNametxt.Text + "','" + regSchoolNametxt.Text + "','" + majortxt.Text + "','" + addresstxt.Text + "','" + passPasstxt.Text + "')";
                         servercliention.cliention();
                         string sqlsend = Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
                            MessageBox.Show(sqlsend);
                        this.Hide();
                      //  log log2 = new log();
                      //  log2.Show();
            }
              
            else
                MessageBox.Show("信息不完整，注册失败！");
        }

        private void companyAddLab_Click(object sender, EventArgs e)
        {

        }

        private void companyRegBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}

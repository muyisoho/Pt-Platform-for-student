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
    public partial class firstPage : Form
    {
        public firstPage()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void firstPage_Load(object sender, EventArgs e)
        {
            panel14.Visible = false;
           
              servercliention.clientsql="4#"+"select id,jname,jdescription,jrequire,jsalary,jaddress,jconnection,jtelephone from job";
                    servercliention.cliention();
                    Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
                   DataSet ds=mymean.ByteToDataset(servercliention.result);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;                                                
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            personPage pp = new personPage();
            pp.Show();*/
        }

        private void label10_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            changePass cp = new changePass();
            cp.Show();*/
        }

        private void label11_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            unlogin up = new unlogin();
            up.Show();*/
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (panel14.Visible == false)
            {
                panel14.Visible = true;
            }
            else {
                panel14.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index; //获取选中行的行号
            string s = dataGridView1.Rows[index].Cells[0].Value.ToString();//Cells[0]为要选的第几列
            o.user.job_id = s;
            this.Hide();
           /* jobInfo ji = new jobInfo();
            ji.Show();*/
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            servercliention.clientsql = "4#" + "select id,jname,jdescription,jrequire,jsalary,jaddress,jconnection,jtelephone from job where jname like '%" + textBox1.Text.Trim() + "%'";
          servercliention.cliention();
                    Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
                   DataSet ds=mymean.ByteToDataset(servercliention.result);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;

        }
    }
        }
    


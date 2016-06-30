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
using findtool;
using SocketServer;

namespace o
{
    public partial class unlogin : Form
    {
        public unlogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int index = dataGridView1.SelectedRows[0].Index; //获取选中行的行号
            string s = dataGridView1.Rows[index].Cells[0].Value.ToString();//Cells[0]为要选的第几列
            o.user.job_id = s;
            this.Hide();
            jobInfo ji = new jobInfo();
            ji.Show();*/
        }

        private void unlogin_Load(object sender, EventArgs e)
        {
                    servercliention.clientsql= "select id,jname,jdescription,jrequire,jsalary,jaddress,jconnection,jtelephone from job";
                    servercliention.cliention();
                    Encoding.UTF8.GetString(servercliention.result, 0, servercliention.receiveLength);
                   DataSet ds=mymean.ByteToDataset(servercliention.result);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;

                
           

        }

        private void register_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            Form1 ff = new Form1();
            ff.Show();*/
        }

        private void login_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            log l = new log();
            l.Show();*/
        }

        private void searchBtn_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            servercliention.clientsql = "select id,jname,jdescription,jrequire,jsalary,jaddress,jconnection,jtelephone from job where jname like '%" + textBox1.Text.Trim() + "%'";
           servercliention.cliention();
           DataSet ds=mymean.ByteToDataset(servercliention.result);
          dataGridView1.DataSource = ds.Tables[0];
          dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          dataGridView1.ReadOnly = true;
          dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
        }
    }
}

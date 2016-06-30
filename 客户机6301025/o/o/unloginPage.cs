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
    public partial class unloginPage : Form
    {
        public unloginPage()
        {
            InitializeComponent();
        }

        private void unloginPage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string ConStr = "server = .;database =studentfindjob;uid =frank;pwd =ludongdaxue";
            conn = new SqlConnection(ConStr);
            conn.Open();
            string str = "select * from job";
            SqlDataAdapter sda = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //string path1 = Application.StartupPath + "/经典散文.jpg";
            //pictureBox1.Image = Image.FromFile(path1);
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //textBox2.Font = new Font(textBox1.Font.FontFamily, 18, textBox1.Font.Style);
            //textBox2.ForeColor = Color.Red;
            textBox2.Text = dt.Rows[0][0].ToString();
            textBox3.Text = dt.Rows[0][1].ToString();
            textBox5.Text = dt.Rows[0][3].ToString();
            textBox6.Text = dt.Rows[0][4].ToString();
            textBox11.Text = dt.Rows[1][0].ToString();
            textBox10.Text = dt.Rows[1][1].ToString();
            textBox8.Text = dt.Rows[1][3].ToString();
            textBox7.Text = dt.Rows[1][4].ToString();
            textBox16.Text = dt.Rows[2][0].ToString();
            textBox15.Text = dt.Rows[2][1].ToString();
            textBox13.Text = dt.Rows[2][3].ToString();
            textBox12.Text = dt.Rows[2][4].ToString();
            textBox21.Text = dt.Rows[3][0].ToString();
            textBox20.Text = dt.Rows[3][1].ToString();
            textBox18.Text = dt.Rows[3][3].ToString();
            textBox17.Text = dt.Rows[3][4].ToString();
        }

        private void login_Click(object sender, EventArgs e)
        {
            log log1 = new log();
            log1.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}

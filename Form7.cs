using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select * from course order by cid";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "课程编号";
            dataGridView1.Columns[1].HeaderText = "课程名称";
            dataGridView1.Columns[2].HeaderText = "开课学期";
            dataGridView1.Columns[3].HeaderText = "专业";
            dataGridView1.Columns[4].HeaderText = "学院";
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            Form form = new Form8();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            Form form = new Form9();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form10();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form11();
            form.Show();
            this.Hide();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }
    }
}

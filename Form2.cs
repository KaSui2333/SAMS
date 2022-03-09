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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select * from student order by sid";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "专业";
            dataGridView1.Columns[4].HeaderText = "班级";
            dataGridView1.Columns[5].HeaderText = "学院";
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)//add students msg
        {
            Form form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//delete students msg
        {
            Form form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//updata students msg
        {
            Form form = new Form5();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//search students msg
        {
            Form form = new Form6();
            form.Show();
            this.Hide();
        }
    }
}

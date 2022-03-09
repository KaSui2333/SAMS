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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select * from score order by sid";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "课程编号";
            dataGridView1.Columns[2].HeaderText = "教师编号";
            dataGridView1.Columns[3].HeaderText = "成绩";
            dataGridView1.Columns[4].HeaderText = "录入日期";
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            Form form = new Form18();
            form.Show();
            this.Hide();
        }

        private void Form17_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            Form form = new Form19();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            Form form = new Form20();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//search
        {
            Form form = new Form21();
            form.Show();
            this.Hide();
        }
    }
}

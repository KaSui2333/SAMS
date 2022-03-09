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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select * from score where sid='" + textBox1.Text + "' and cid='"+textBox2.Text+"' and tid='"+textBox3.Text+"'";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "课程编号";
            dataGridView1.Columns[2].HeaderText = "教师编号";
            dataGridView1.Columns[3].HeaderText = "成绩";
            dataGridView1.Columns[4].HeaderText = "录入日期";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form21_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form17();
            form.Show();
        }
    }
}

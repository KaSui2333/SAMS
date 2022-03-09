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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select * from student where sid='"+textBox1.Text+"'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }
    }
}

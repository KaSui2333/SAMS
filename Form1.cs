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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//学生管理
        {
            Form form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//课程管理
        {
            Form form = new Form7();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//教师管理
        {
            Form form = new Form12();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//成绩管理
        {
            Form form = new Form17();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)//查询统计
        {
            Form form = new Form22();
            form.Show();
            this.Hide();
        }
    }
}

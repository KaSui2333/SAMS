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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn conn = new sqlconn();
            string sql = "update course set cname='" + textBox2.Text + "',cterm='" + textBox3.Text + "',special='" + textBox4.Text + "',school='" + textBox5.Text + "' where cid='" + textBox1.Text + "'";
            int result = conn.ExecuteUpdate(sql);
            if (result != 0)
            {
                MessageBox.Show("修改成功", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改失败！请重新修改！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form7();
            form.Show();
        }
    }
}

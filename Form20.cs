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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn conn = new sqlconn();
            string sql = "update score set score='" + textBox4.Text + "',cdate='" + textBox5.Text + "' where sid='" + textBox1.Text + "' and cid='" + textBox2.Text + "' and tid='"+ textBox3.Text+"'";
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

        private void Form20_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form17();
            form.Show();
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn conn = new sqlconn();
            string sql = "update student set name='"+textBox2.Text+"',sex='"+textBox3.Text + "',special='"+textBox4.Text+"',class='"+textBox5.Text+"',school='"+textBox6.Text+"' where sid='" + textBox1.Text + "'";
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
            textBox6.Text = "";
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }
    }
}

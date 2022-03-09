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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn conn = new sqlconn();
            string sql = "insert into student values('"
                +textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text  + "','" + textBox4.Text + "','" + textBox5.Text + "','" +textBox6.Text + "')" ;
            int result = conn.ExecuteUpdate(sql);
            if (result != 0)
            {
                MessageBox.Show("添加成功", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("添加失败！请重新添加！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form2();
            form.Show();
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
    }
}

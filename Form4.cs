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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn conn = new sqlconn();
            string sql = "delete from student where sid='"+textBox1.Text+"'";
            int result = conn.ExecuteUpdate(sql);
            if (result != 0)
            {
                MessageBox.Show("删除成功", "删除结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除失败！请重新删除！", "删除结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}

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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select std.class,std.sid,std.name,cou.cname,tea.tname,sco.score from student std,course cou, teacher tea,score sco where std.sid = sco.sid and tea.tid = sco.tid and cou.cid = sco.cid and cou.cid = tea.cid order by std.class";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "班级";
            dataGridView1.Columns[1].HeaderText = "学号";
            dataGridView1.Columns[2].HeaderText = "姓名";
            dataGridView1.Columns[3].HeaderText = "课程";
            dataGridView1.Columns[4].HeaderText = "教师";
            dataGridView1.Columns[5].HeaderText = "成绩";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select std.class,std.sid,std.name,cou.cname,tea.tname,sco.score from student std,course cou, teacher tea,score sco where std.sid = sco.sid and tea.tid = sco.tid and cou.cid = sco.cid and cou.cid = tea.cid order by std.name";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "班级";
            dataGridView1.Columns[1].HeaderText = "学号";
            dataGridView1.Columns[2].HeaderText = "姓名";
            dataGridView1.Columns[3].HeaderText = "课程";
            dataGridView1.Columns[4].HeaderText = "教师";
            dataGridView1.Columns[5].HeaderText = "成绩";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select std.sid,std.name,sum(sco.score) from student std,score sco where std.sid = sco.sid group by std.sid,std.name order by sum(sco.score) desc";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "总成绩";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select std.sid,std.name,avg(sco.score) from student std,score sco where std.sid = sco.sid group by std.sid,std.name order by avg(sco.score) desc";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "平均成绩";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select sum(case when score between 90 and 100 then 1 else 0 end) as A,sum(case when score between 80 and 89 then 1 else 0 end) as B,sum(case when score between 70 and 79 then 1 else 0 end) as C,sum(case when score between 60 and 69 then 1 else 0 end) as D,sum(case when score < 60 then 1 else 0 end) as E from score";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "A";
            dataGridView1.Columns[1].HeaderText = "B";
            dataGridView1.Columns[2].HeaderText = "C";
            dataGridView1.Columns[3].HeaderText = "D";
            dataGridView1.Columns[4].HeaderText = "E";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            sqlconn conn = new sqlconn();
            string sql = "select sum(case when score between 90 and 100 then 1 else 0 end)*1.0 / count(*) * 100 as A,sum(case when score between 80 and 89 then 1 else 0 end)*1.0 / count(*) * 100 as B,sum(case when score between 70 and 79 then 1 else 0 end)*1.0 / count(*) * 100 as C,sum(case when score between 60 and 69 then 1 else 0 end)*1.0 / count(*) * 100 as D,sum(case when score < 60 then 1 else 0 end)*1.0 / count(*) * 100 as E from score";
            DataTable d1 = new DataTable();
            d1 = conn.ExecuteQuery(sql);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "A";
            dataGridView1.Columns[1].HeaderText = "B";
            dataGridView1.Columns[2].HeaderText = "C";
            dataGridView1.Columns[3].HeaderText = "D";
            dataGridView1.Columns[4].HeaderText = "E";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 第二题.Classes;

namespace 第二题
{
    public partial class CourseSelect : Form
    {
        DataSet ds;
        public CourseSelect()
        {
            InitializeComponent();
        }

        private void CourseSelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }
        DataSet Bind()
        {
            CourseInfoData data = new CourseInfoData();
            data.Kcid = txtKcid.Text;
            data.Kcname = txtKcname.Text;

            Classes.CourseInfoOperation op = new Classes.CourseInfoOperation();
            ds = op.GetCourseInfo(data);
            return ds;
        }

        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }

        //dataGridView显示数据
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtKcid1.Text = ds.Tables[0].Rows[i][0].ToString();
            txtKcname1.Text = ds.Tables[0].Rows[i][1].ToString();
            txtPeriodexpriment1.Text = ds.Tables[0].Rows[i][2].ToString();
            txtPeriodteaching1.Text = ds.Tables[0].Rows[i][3].ToString();
            txtCredit1.Text = ds.Tables[0].Rows[i][4].ToString();
            txtCoursetype1.Text = ds.Tables[0].Rows[i][5].ToString();

        }

        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            CourseInfoData data = new CourseInfoData();
            data.Kcid = txtKcid1.Text;
            data.Kcname = txtKcname1.Text;
            data.Periodexpriment = int.Parse(txtPeriodexpriment1.Text);
            data.Periodteaching = int.Parse(txtPeriodteaching1.Text);
            data.Credit = float.Parse(txtCredit1.Text);
            data.Coursetype = txtCoursetype1.Text;

            Classes.CourseInfoOperation op = new Classes.CourseInfoOperation();
            if (op.UpdateCourse(data))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }


        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            string kcid = txtKcid1.Text;
            Classes.CourseInfoOperation op = new Classes.CourseInfoOperation();
            if (op.DeleteCourse(kcid))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }
    }
}

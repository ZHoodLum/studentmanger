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
    public partial class CourseAdd : Form
    {
        public CourseAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseInfoData data = new CourseInfoData();
            data.Kcid = txtKcid.Text;
            data.Kcname = txtKcname.Text;
            data.Periodexpriment = int.Parse(txtPeriodexpriment.Text);
            data.Periodteaching = int.Parse(txtPeriodteaching.Text);
            data.Credit = float.Parse(txtCredit.Text);
            data.Coursetype = txtCoursetype.Text;

            if (txtKcid.Text == "" || txtKcid.Text == null)
            {
                MessageBox.Show("课程编号不能为空");
                txtKcid.Focus();
                return;
            }
            Classes.CourseInfoOperation op = new Classes.CourseInfoOperation();

            if (op.InsertCourseInfo(data))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("失败");
        }   

    }
}

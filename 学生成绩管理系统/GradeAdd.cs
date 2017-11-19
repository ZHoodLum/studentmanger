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
    public partial class GradeAdd : Form
    {
        public GradeAdd()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StuGradeData data = new StuGradeData();
            data.Sno = txtSno.Text;
            data.Cno = txtCno.Text;
            data.Gradepeacetime = float.Parse(txtGradepeacetime.Text);
            data.Gradeexpriment = float.Parse(txtGradeexpriment.Text);
            data.Gradelast = float.Parse(txtGradelast.Text);
            data.Grade = float.Parse(txtGrade.Text);
            if (txtSno.Text == "" || txtSno.Text == null)
            {
                MessageBox.Show("学号不能为空");
                txtSno.Focus();
                return;
            }
            Classes.StuGradeOperation op = new Classes.StuGradeOperation();

            if (op.InsertStuGrade(data))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("失败");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtGradepeacetime.Text);
            int b = int.Parse(txtGradeexpriment.Text);
            int c = int.Parse(txtGradelast.Text);
            double x = a * 0.1 + b * 0.2 + c * 0.7;
            float y = (float)x;
            txtGrade.Text = y.ToString();
        }  



    }
}

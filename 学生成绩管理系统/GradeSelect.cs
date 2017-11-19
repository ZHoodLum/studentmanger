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
    public partial class GradeSelect : Form
    {
        DataSet ds;
        public GradeSelect()
        {
            InitializeComponent();
        }
        private void GradeSelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }
        DataSet Bind()
        {
            StuGradeData data = new StuGradeData();
            data.Sno = txtSno.Text;
            data.Cno = txtCno.Text;

            Classes.StuGradeOperation op = new Classes.StuGradeOperation();
            ds = op.GetStuGrade(data);
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
            txtSno1.Text = ds.Tables[0].Rows[i][0].ToString();
            txtCno1.Text = ds.Tables[0].Rows[i][1].ToString();
            txtGradepeacetime1.Text = ds.Tables[0].Rows[i][2].ToString();
            txtGradeexpriment1.Text = ds.Tables[0].Rows[i][3].ToString();
            txtGradelast1.Text = ds.Tables[0].Rows[i][4].ToString();
            txtGrade1.Text = ds.Tables[0].Rows[i][5].ToString();

        }

        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            StuGradeData data = new StuGradeData();
            data.Sno = txtSno1.Text;
            data.Cno = txtCno1.Text;
            data.Gradepeacetime = float.Parse(txtGradepeacetime1.Text);
            data.Gradeexpriment = float.Parse(txtGradeexpriment1.Text);
            data.Gradelast = float.Parse(txtGradelast1.Text);
            data.Grade = float.Parse(txtGrade1.Text);

            Classes.StuGradeOperation op = new Classes.StuGradeOperation();
            if (op.UpdateStuGrade(data))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }


        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            string sno = txtSno1.Text;
            Classes.StuGradeOperation op = new Classes.StuGradeOperation();
            if (op.DeleteStuGrade(sno))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }

    }
}

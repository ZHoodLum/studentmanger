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
    public partial class TeacherSelect : Form
    {
        DataSet ds;
        public TeacherSelect()
        {
            InitializeComponent();
        }
        private void TeacherSelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }
        DataSet Bind()
        {
            TeacherInfoData data = new TeacherInfoData();
            data.Teaid = txtTeaid.Text;
            data.Teaname = txtTeaname.Text;
            data.Teasex = txtTeasex.Text;
            data.Teabirthday = txtTeabirthday.Text;

            Classes.TeacherInfoOperation op = new Classes.TeacherInfoOperation();
            ds = op.GetTeacherInfo(data);
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
            txtTeaid1.Text = ds.Tables[0].Rows[i][0].ToString();
            txtTeaname1.Text = ds.Tables[0].Rows[i][1].ToString();
            txtTeasex1.Text = ds.Tables[0].Rows[i][2].ToString();
            txtTeloffice1.Text = ds.Tables[0].Rows[i][3].ToString();
            txtAddress1.Text = ds.Tables[0].Rows[i][4].ToString();
            txtTeabirthday1.Text = ds.Tables[0].Rows[i][5].ToString();

        }

        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            TeacherInfoData data = new TeacherInfoData();
            data.Teaid = txtTeaid1.Text;
            data.Teaname = txtTeaname1.Text;
            data.Teasex = txtTeasex1.Text;
            data.Teloffice = txtTeloffice1.Text;
            data.Address = txtAddress1.Text;
            data.Teabirthday = txtTeabirthday1.Text;

            Classes.TeacherInfoOperation op = new Classes.TeacherInfoOperation();
            if (op.UpdateTeacher(data))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }


        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            string sno = txtTeaid1.Text;
            Classes.TeacherInfoOperation op = new Classes.TeacherInfoOperation();
            if (op.DeleteTeacher(sno))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }

    }
}

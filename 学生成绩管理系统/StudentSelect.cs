using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 第二题
{
    public partial class StudentSelect : Form
    {
        DataSet ds;
        public StudentSelect()
        {
            InitializeComponent();
        }

        private void StudentSelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }
         DataSet Bind()
        {
            StudentInfoData data = new StudentInfoData();
            data.Sno = txtSno.Text;
            data.Sname = txtSname.Text;
            data.Sex = txtSex.Text;
            data.Classid = txtClass.Text;
            Classes.StudentInfoOperation op = new Classes.StudentInfoOperation();
            ds = op.GetStudentInfo(data);
            return ds;
        }
        //查询
         private void button1_Click(object sender, EventArgs e)
         {
             dataGridView1.DataSource = Bind().Tables[0];
         }
        //显示数据
         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             int i = e.RowIndex;
             txtSno1.Text = ds.Tables[0].Rows[i][0].ToString();
             txtSname1.Text = ds.Tables[0].Rows[i][1].ToString();
             txtSex1.Text = ds.Tables[0].Rows[i][2].ToString();
             txtBirthday1.Text = ds.Tables[0].Rows[i][3].ToString();
             txtClassid1.Text = ds.Tables[0].Rows[i][4].ToString();
             txtTel1.Text = ds.Tables[0].Rows[i][5].ToString();
             txtAddress1.Text = ds.Tables[0].Rows[i][6].ToString();
   
         }

        //修改
         private void button2_Click(object sender, EventArgs e)
         {
             StudentInfoData data = new StudentInfoData();
             data.Sno = txtSno1.Text;
             data.Sname = txtSname1.Text;
             data.Sex = txtSex1.Text;
             data.Birthday = txtBirthday1.Text;
             data.Classid = txtClass.Text;
             data.Tel = txtTel1.Text;
             data.Address = txtAddress1.Text;
             Classes.StudentInfoOperation op = new Classes.StudentInfoOperation();
             if (op.UpdateStudent(data))
                 MessageBox.Show("成功");
             else
                 MessageBox.Show("失败了");
             dataGridView1.DataSource = Bind().Tables[0];
         }

        //删除
         private void button3_Click(object sender, EventArgs e)
         {
             string sno = txtSno1.Text;
             Classes.StudentInfoOperation op = new Classes.StudentInfoOperation();
             if(op.DeleteStudent(sno))
                 MessageBox.Show("成功");
             else
                 MessageBox.Show("失败了");
             dataGridView1.DataSource = Bind().Tables[0];
         }
    }
}

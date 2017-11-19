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
    public partial class ClassSelect : Form
    {
        DataSet ds;
        public ClassSelect()
        {
            InitializeComponent();
        }

         private void ClassSelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }
        DataSet Bind()
        {
            ClassInfoData data = new ClassInfoData();
            data.Classid = txtClassid.Text;
            data.Specialtyid = txtSpecialtyid.Text;

            Classes.ClassInfoOperation op = new Classes.ClassInfoOperation();
            ds = op.GetClassInfo(data);
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
            txtClassid1.Text = ds.Tables[0].Rows[i][0].ToString();
            txtSpecialtyid1.Text = ds.Tables[0].Rows[i][1].ToString();
            txtStudentnumber1.Text = ds.Tables[0].Rows[i][2].ToString();
            txtRemark1.Text = ds.Tables[0].Rows[i][3].ToString();

        }

        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            ClassInfoData data = new ClassInfoData();
            data.Classid = txtClassid1.Text;
            data.Specialtyid = txtSpecialtyid1.Text;
            data.Studentnumber = int.Parse(txtStudentnumber1.Text);
            data.Remark = txtRemark1.Text;

            Classes.ClassInfoOperation op = new Classes.ClassInfoOperation();
            if (op.UpdateClass(data))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }


        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            string classid = txtClassid1.Text;
            Classes.ClassInfoOperation op = new Classes.ClassInfoOperation();
            if (op.DeleteClass(classid))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }
    }
}

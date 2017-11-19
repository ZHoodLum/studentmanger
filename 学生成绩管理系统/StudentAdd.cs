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
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoData data = new StudentInfoData();
            data.Sno = txtSno.Text;
            data.Sname = txtSname.Text;
            if (rdoMale.Checked)
                data.Sex = rdoMale.Text;
            else
                data.Sex = rdoFemale.Text;
            data.Birthday = txtBirthday.Text;
            data.Classid = txtClassid.Text;
            data.Tel = txtTel.Text;
            data.Address = txtAddress.Text;
            if (txtSno.Text == "" || txtSno.Text == null)
            {
                MessageBox.Show("学号不能为空");
                txtSno.Focus();
                return;
            }
            Classes.StudentInfoOperation op = new Classes.StudentInfoOperation();

            if (op.InsertStudentInfo(data))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("失败");
           
           
        }
    }
}

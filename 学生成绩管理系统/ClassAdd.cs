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
    public partial class ClassAdd : Form
    {
        public ClassAdd()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClassInfoData data = new ClassInfoData();
            data.Classid = txtClassid.Text;
            data.Specialtyid = txtSpecialtyid.Text;
            data.Studentnumber = int.Parse(txtStudentnumber.Text);
            data.Remark = txtRemark.Text;

            if (txtClassid.Text == "" || txtClassid.Text == null)
            {
                MessageBox.Show("用户名不能为空");
                txtClassid.Focus();
                return;
            }
            Classes.ClassInfoOperation op = new Classes.ClassInfoOperation();

            if (op.InsertClassInfo(data))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("失败");
        }   
    }
}

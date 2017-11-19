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
    public partial class TeacherAdd : Form
    {
        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherInfoData data = new TeacherInfoData();
            data.Teaid = txtTeaid.Text;
            data.Teaname = txtTeaname.Text;
            data.Teasex = txtTeasex.Text;
            data.Teloffice = txtTeloffice.Text;
            data.Address = txtAddress.Text;
            data.Teabirthday = txtTeabirthday.Text;
            if (txtTeaid.Text == "" || txtTeaid.Text == null)
            {
                MessageBox.Show("用户名不能为空");
                txtTeaid.Focus();
                return;
            }
            Classes.TeacherInfoOperation op = new Classes.TeacherInfoOperation();

            if (op.InsertTeacherInfo(data))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("失败");
        }
    }
}

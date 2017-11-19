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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfoData data = new UserInfoData();
            data.Userid = txtUserid.Text;
            data.Userpwd = txtUserpwd.Text;
            data.Userlevel = txtUserlevel.Text;
            if (txtUserid.Text == "" || txtUserid.Text == null)
            {
                MessageBox.Show("用户名不能为空");
                txtUserid.Focus();
                return;
            }
            Classes.UserInfoOperation op = new Classes.UserInfoOperation();

            if (op.InsertUserInfo(data))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("失败");
        }      
    }
}

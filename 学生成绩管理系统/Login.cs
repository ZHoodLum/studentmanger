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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, pwd;
            if (txtUserid.Text.Trim() != "" && txtUserpwd.Text.Trim() != "")
            {
                name = txtUserid.Text.Trim();
                pwd = txtUserpwd.Text.Trim();
                DataAccess data = new DataAccess();
                if (data.CheckAdmin(name, pwd))
                {
                    Classes.Constants.Username = txtUserid.Text.Trim();

                    Form1 winmain = new Form1();
                    winmain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误,请重新登录!");
                    txtUserid.Text = "";
                    txtUserpwd.Text="";
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

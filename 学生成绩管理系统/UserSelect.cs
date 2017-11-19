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
    public partial class UserSelect : Form
    {
        DataSet ds;
        public UserSelect()
        {
            InitializeComponent();
        }

        private void UserSelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }
        DataSet Bind()
        {
            UserInfoData data = new UserInfoData();
            data.Userid = txtUserid.Text;
            data.Userlevel = txtUserlevel.Text;
            Classes.UserInfoOperation op = new Classes.UserInfoOperation();
            ds = op.GetUserInfo(data);
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
            txtUserid1.Text = ds.Tables[0].Rows[i][0].ToString();
            txtUserpwd1.Text = ds.Tables[0].Rows[i][1].ToString();
            txtUserlevel1.Text = ds.Tables[0].Rows[i][2].ToString();

        }

        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            UserInfoData data = new UserInfoData();
            data.Userid = txtUserid1.Text;
            data.Userpwd = txtUserpwd1.Text;
            data.Userlevel = txtUserlevel1.Text;
            Classes.UserInfoOperation op = new Classes.UserInfoOperation();
            if (op.UpdateUser(data))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }


        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            string sno = txtUserid1.Text;
            Classes.UserInfoOperation op = new Classes.UserInfoOperation();
            if (op.DeleteUser(sno))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 作业登陆界面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source = .; integrated security = sspi; initial catalog = xscjgl";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from userinfo where userid = '" + textBox1.Text + "'";
            cmd.CommandText = "select * from userinfo where userpwd = '" + textBox2.Text + "'";
            cn.Open();

            String i = textBox1.Text.ToString();
            cmd.Connection = cn;
            String d = Convert.ToString(cmd.ExecuteScalar());
            cn.Close();

            if (i.Equals(d))
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("密码或用户名错误");
            }
        }
    }
}

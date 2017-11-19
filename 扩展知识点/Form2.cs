using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 扩展知识点
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=.;integrated security=sspi;initial catalog=xscjgl";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            string sql = "insert into studentinfo values('" + txtSno.Text
                + "','" + txtSname.Text + "','" + txtSex.Text + "','"
                + txtBirthday.Text + "','" + txtClassid.Text + "','"
                + txtTel.Text + "','" + txtAddress.Text + "')";
            cmd.CommandText = sql;
            cmd.Connection = cn;
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("插入成功");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            


        }
    }
}

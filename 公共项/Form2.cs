using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 公共项
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtclassid_Click(object sender, EventArgs e)
        {

        }

        private void txtsno_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source = .;integrated security = sspi;initial catalog = xscjgl";
            cn.Open();

            SqlCommand cmd = new SqlCommand();

            string sql = "insert into studentinfo values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";


            cmd.CommandText = sql;
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();


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

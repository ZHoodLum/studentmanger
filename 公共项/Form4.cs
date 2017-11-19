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
    public partial class Form4 : Form
    {

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source = .;integrated security = sspi;initial catalog = xscjgl";

            da = new SqlDataAdapter ("select * from studentinfo",cn);
            ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = new e.RowIndex();
            textBox1.Text = ds.Tables[0].Rows[i][1].ToString();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

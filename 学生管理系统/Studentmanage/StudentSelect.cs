using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studentmanage
{
    public partial class StudentSelect : Form

    {
        DataSet ds;
        public StudentSelect()
        {
            InitializeComponent();
        }

        private void StudentSelect_Load(object sender, EventArgs e)
        {

        }
        DataSet Bind()
        {
            StudentInfoDate data = new StudentInfoDate();
            data.Sno = txtSno.Text;
            data.Sname = txtSname.Text;
            data.Sex = txtSex.Text;
            data.Classid = txtClass.Text;
            Classes.StudentInfoOperation op = new Classes.StudentInfoOperation();
            ds = op.GetStudentInfo(data);
            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtSno1.Text = ds.Tables[0].Rows[i][0].ToString();
            txtSname1.Text = ds.Tables[1].Rows[i][1].ToString();
            txtSex.Text = ds.Tables[2].Rows[i][2].ToString();
            txtClassid1.Text = ds.Tables[3].Rows[i][3].ToString();
            txtAddress1.Text = ds.Tables[4].Rows[i][4].ToString();
            txtTel1.Text = ds.Tables[5].Rows[i][5].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInfoDate data = new StudentInfoDate();
            data.Sno = txtSno1.Text;
            data.Sname = txtSname1.Text;
            data.Sex = txtSex.Text;
            data.Classid = txtClassid1.Text;
            data.Address = txtAddress1.Text;
            data.Tel = txtTel1.Text;
        }

    }
}

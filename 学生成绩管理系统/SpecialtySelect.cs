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
    public partial class SpecialtySelect : Form
    {
        DataSet ds;
        public SpecialtySelect()
        {
            InitializeComponent();
        }

        private void SpecialtySelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bind().Tables[0];
        }
        DataSet Bind()
        {
            SpecialtyInfoData data = new SpecialtyInfoData();
            data.Specialtyid = txtSpecialtyid.Text;
            data.Specialtymc = txtSpecialtymc.Text;

            Classes.SpecialtyInfoOperation op = new Classes.SpecialtyInfoOperation();
            ds = op.GetSpecialtyInfo(data);
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
            txtSpecialtyid1.Text = ds.Tables[0].Rows[i][0].ToString();
            txtSpecialtymc1.Text = ds.Tables[0].Rows[i][1].ToString();

        }

        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            SpecialtyInfoData data = new SpecialtyInfoData();
            data.Specialtyid = txtSpecialtyid1.Text;
            data.Specialtymc = txtSpecialtymc1.Text;

            Classes.SpecialtyInfoOperation op = new Classes.SpecialtyInfoOperation();
            if (op.UpdateSpecialty(data))
                MessageBox.Show("成功了");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }


        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            string specialtyid = txtSpecialtyid1.Text;
            Classes.SpecialtyInfoOperation op = new Classes.SpecialtyInfoOperation();
            if (op.DeleteSpecialty(specialtyid))
                MessageBox.Show("成功");
            else
                MessageBox.Show("失败了");
            dataGridView1.DataSource = Bind().Tables[0];
        }
    }
}

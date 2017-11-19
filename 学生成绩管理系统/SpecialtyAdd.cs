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
    public partial class SpecialtyAdd : Form
    {
        public SpecialtyAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecialtyInfoData data = new SpecialtyInfoData();
            data.Specialtymc = txtSpecialtymc.Text;
            data.Specialtyid = txtSpecialtyid.Text;

            if (txtSpecialtyid.Text == "" || txtSpecialtyid.Text == null)
            {
                MessageBox.Show("用户名不能为空");
                txtSpecialtyid.Focus();
                return;
            }
            Classes.SpecialtyInfoOperation op = new Classes.SpecialtyInfoOperation();

            if (op.InsertSpecialtyInfo(data))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("失败");
        }   

    }
}

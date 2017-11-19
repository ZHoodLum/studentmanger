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
    public partial class rdomale : Form
    {
        public rdomale()
        {
            InitializeComponent();
        }

        private void rdomale_Load(object sender, EventArgs e)
        {
            StudentInfoDate data = new StudentInfoDate();
            data.Sno = txtSno.Text;
            if(rdoman.Checked)
                data.Sex = rdoman.Text;
                else
                data.Sex = rdowoman.Text;
                data.Brithday = txtBirthday.Text;
                data.Classid = txtSno.Text;
                data.Tel = txtTel.Text;
                data.Address = txtAddress.Text;

                if(txtSno.Text==""||txtSno.Text==null)
                {
                    MessageBox.Show("学号不能为空");
                    txtSno.Focus();
                    return;
                }
                Classes.StudentInfoOperation op = new Classes.StudentInfoOperation();
                if(op.InertStudentInfo(data))
                    MessageBox.Show("插入成功");
                else
                    MessageBox.Show("插入失败");
        }
    }
}

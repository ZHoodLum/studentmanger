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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 系统管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 用户查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdd a = new UserAdd();
            a.MdiParent = this;
            a.Show();
        }

        private void 学生信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmStudentAdd a = new FrmStudentAdd();
          // a.MdiParent = this;
           // a.show();

            StudentSelect ss = new StudentSelect();
            ss.MdiParent = this;
            ss.Show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 第一个窗体程序
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
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text,"提示",MessageBoxButtons.YesNoCancel);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

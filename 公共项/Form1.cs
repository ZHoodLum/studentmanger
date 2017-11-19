using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 公共项
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("鼠标事件");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("我能送你回家吗，可能外面已经下雨啦");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

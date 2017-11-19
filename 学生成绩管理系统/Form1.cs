using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 第二题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Classes.UserInfoData data = new Classes.UserInfoData();
            data.Userid = Classes.Constants.Username;
            DataSet ds = Classes.UserInfoOperation.GetUserInfoAll(data);
            if(ds.Tables[0].Rows.Count>0){
                //获取用户身份
                Classes.Constants.Userlevel = ds.Tables[0].Rows[0]["Userlevel"].ToString();
                //登陆身份是学生，设置某些模块不可用
                if (Classes.Constants.Userlevel == "学生")
                {
                    this.用户修改ToolStripMenuItem.Enabled = false;
                    this.用户删除ToolStripMenuItem.Enabled = false;
                    this.用户增加ToolStripMenuItem.Enabled = false;

                    this.成绩信息添加ToolStripMenuItem.Enabled = false;
                    this.成绩信息删除ToolStripMenuItem.Enabled = false;
                    this.成绩信息修改ToolStripMenuItem.Enabled = false;

                    this.课程信息删除ToolStripMenuItem.Enabled = false;
                    this.课程信息添加ToolStripMenuItem.Enabled = false;
                    this.课程信息修改ToolStripMenuItem.Enabled = false;

                    this.班级信息删除ToolStripMenuItem.Enabled = false;
                    this.班级信息添加ToolStripMenuItem.Enabled = false;
                    this.班级信息修改ToolStripMenuItem.Enabled = false;

                    this.学生信息删除ToolStripMenuItem.Enabled = false;
                    this.学生信息增加ToolStripMenuItem.Enabled = false;
                    this.学生信息修改ToolStripMenuItem.Enabled = false;

                    this.专业信息删除ToolStripMenuItem.Enabled = false;
                    this.专业信息添加ToolStripMenuItem.Enabled = false;
                    this.专业信息修改ToolStripMenuItem.Enabled = false;

                    this.教师信息删除ToolStripMenuItem.Enabled = false;
                    this.教师信息添加ToolStripMenuItem.Enabled = false;
                    this.教师信息修改ToolStripMenuItem.Enabled = false;

                }
                //登陆身份是任课教师，设置某些模块不可用
                else if (Classes.Constants.Userlevel == "教师")
                {
                    this.用户修改ToolStripMenuItem.Enabled = false;
                    this.用户删除ToolStripMenuItem.Enabled = false;
                   // this.用户增加ToolStripMenuItem.Enabled = false;

                    this.成绩信息删除ToolStripMenuItem.Enabled = false;
                    this.成绩信息修改ToolStripMenuItem.Enabled = false;
                    //this.成绩信息添加ToolStripMenuItem.Enabled = false;

                    this.课程信息删除ToolStripMenuItem.Enabled = false;
                   // this.课程信息添加ToolStripMenuItem.Enabled = false;
                    this.课程信息修改ToolStripMenuItem.Enabled = false;

                    this.班级信息删除ToolStripMenuItem.Enabled = false;
                    //this.班级信息添加ToolStripMenuItem.Enabled = false;
                    this.班级信息修改ToolStripMenuItem.Enabled = false;

                    this.学生信息删除ToolStripMenuItem.Enabled = false;
                    //this.学生信息增加ToolStripMenuItem.Enabled = false;
                    this.学生信息修改ToolStripMenuItem.Enabled = false;

                    this.专业信息删除ToolStripMenuItem.Enabled = false;
                    //this.专业信息添加ToolStripMenuItem.Enabled = false;
                    this.专业信息修改ToolStripMenuItem.Enabled = false;

                    this.教师信息删除ToolStripMenuItem.Enabled = false;
                   // this.教师信息添加ToolStripMenuItem.Enabled = false;
                    this.教师信息修改ToolStripMenuItem.Enabled = false;

                }
            }
        }
        //退出项目文件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //跳出登陆模块
        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        //实现关于版本信息
        private void 管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生成绩管理系统V1.0", "版本信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        //用户管理
        private void 用户添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdd a = new UserAdd();
            a.MdiParent = this;
            a.Show();
        }

        private void 用户查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSelect ss = new UserSelect();
            ss.MdiParent = this;
            ss.Show();
        }

        //学生管理
        private void 学生信息增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAdd a = new StudentAdd();
            a.MdiParent = this;
            a.Show();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSelect ss = new StudentSelect();
            ss.MdiParent = this;
            ss.Show();
        }
        //课程管理
        private void 课程信息添加ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CourseAdd a = new CourseAdd();
            a.MdiParent = this;
            a.Show();
        }

        private void 课程信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseSelect ss = new CourseSelect();
            ss.MdiParent = this;
            ss.Show();
        }

        //教室管理
        private void 教师信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAdd a = new TeacherAdd();
            a.MdiParent = this;
            a.Show();
        }

        private void 教师信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherSelect ss = new TeacherSelect();
            ss.MdiParent = this;
            ss.Show();
        }

        //成绩管理

        private void 成绩信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeAdd a = new GradeAdd();
            a.MdiParent = this;
            a.Show();
        }

        private void 成绩信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeSelect ss = new GradeSelect();
            ss.MdiParent = this;
            ss.Show();
        }

        //班级管理
        private void 班级信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassAdd a = new ClassAdd();
            a.MdiParent = this;
            a.Show();
        }

        private void 班级信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassSelect ss = new ClassSelect();
            ss.MdiParent = this;
            ss.Show();
        }


        //专业管理
        private void 专业信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SpecialtySelect ss = new SpecialtySelect();
            ss.MdiParent = this;
            ss.Show();
        }

        private void 专业信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialtyAdd a = new SpecialtyAdd();
            a.MdiParent = this;
            a.Show();
        }

        

    }
}

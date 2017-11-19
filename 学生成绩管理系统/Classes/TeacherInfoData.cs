using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
   public class TeacherInfoData
    {
        //教师代码
        private string teaid;
        public string Teaid
        {
            get { return teaid; }
            set { teaid = value; }
        }
        //教师姓名
        private string teaname;
        public string Teaname
        {
            get { return teaname; }
            set { teaname = value; }
        }
        //教师性别
        private string teasex;
        public string Teasex
        {
            get { return teasex; }
            set { teasex = value; }
        }
        //办公电话
        private string teloffice;

        public string Teloffice
        {
            get { return teloffice; }
            set { teloffice = value; }
        }
        //家庭住址
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        //生日日期
        private string teabirthday;

        public string Teabirthday
        {
            get { return teabirthday; }
            set { teabirthday = value; }
        }
    }
}

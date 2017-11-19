using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
    public class ClassInfoData
    {
        //班级号
        private string classid;

        public string Classid
        {
            get { return classid; }
            set { classid = value; }
        }
        //专业代码
        private string specialtyid;

        public string Specialtyid
        {
            get { return specialtyid; }
            set { specialtyid = value; }
        }
        //班级人数
        private int studentnumber;

        public int Studentnumber
        {
            get { return studentnumber; }
            set { studentnumber = value; }
        }
        //备注
        private string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
    public class CourseInfoData
    {
        //课程id
        private string kcid;
        public string Kcid
        {
            get { return kcid; }
            set { kcid = value; }
        }
        //课程名字
        private string kcname;
        public string Kcname
        {
            get { return kcname; }
            set { kcname = value; }
        }
        //课程实验学时
        private int periodexpriment;
        public int Periodexpriment
        {
            get { return periodexpriment; }
            set { periodexpriment = value; }
        }
        //课程讲课学时
        private int  periodteaching;
        public int Periodteaching
        {
            get { return periodteaching; }
            set { periodteaching = value; }
        }
        //课程的学分
        private float credit;
        public float Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        //课程类型
        private string coursetype;
        public string Coursetype
        {
            get { return coursetype; }
            set { coursetype = value; }
        }
    }
}

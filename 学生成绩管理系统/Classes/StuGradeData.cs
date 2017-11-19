using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
   public class StuGradeData
    {
       //学号
        private string sno;

        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
       //课程号
        private string cno;

        public string Cno
        {
            get { return cno; }
            set { cno = value; }
        }
       //平时成绩
        private float gradepeacetime;

        public float Gradepeacetime
        {
            get { return gradepeacetime; }
            set { gradepeacetime = value; }
        }
       //实验成绩
        private float gradeexpriment;

        public float Gradeexpriment
        {
            get { return gradeexpriment; }
            set { gradeexpriment = value; }
        }
       //期末成绩
        private float gradelast;

        public float Gradelast
        {
            get { return gradelast; }
            set { gradelast = value; }
        }
       //总成绩
        private float grade;

        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}

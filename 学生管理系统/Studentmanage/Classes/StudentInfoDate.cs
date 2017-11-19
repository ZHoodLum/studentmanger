using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studentmanage
{
    class StudentInfoDate
    {
        private string sno = "";
        private string sname = "";
        private string sex = ""; 
        private string brithday = "";
        private string address = "";
        private string tel = "";
        private string classid = "";


        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Brithday
        {
            get { return brithday; }
            set { brithday = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Classid
        {
            get { return classid; }
            set { classid = value; }
        }


    }
}

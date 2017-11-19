using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studentmanage.Classes
{
    public class StudentInfoOperation
    {
        public bool InertStudentInfo (StudentInfoDate data)
        {
            string sql = "insert into studentinfo(Sno,Sname,Sex,.Brithday,Classid,Tel,Address) values('" + data.Sno + "','" + data.Sname + "','" + data.Sex + "','" + data.Brithday + "','" + data.Classid + "','" + data.Tel + "','" + data.Address + "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);

        }

        public System.Data.DataSet GetStudentInfo(StudentInfoDate data)
        {
            string sql = "select * from studentinfo where 1=1";
            string s = " ";
            if (data.Sno != "" && data.Sno != null)
                s += " and sno='" + data.Sno + "'";
            if (data.Sname != "" && data.Sname != null)
                s += " and sname='" + data.Sname + "'";
            if (data.Sex != "" && data.Sex != null)
                s += " and sex='" + data.Sex + "'";
            if (data.Classid != "" && data.Classid != null)
                s += " and classid='" + data.Classid + "'";

            sql += s;

            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "studentinfo");
        }


        //修改
        private bool UpdateStudent(StudentInfoDate data)
        {
            string sql = "update studentinfo set sname='" + data.Sname +
                "',sno='" + data.Sno +
                "',sex='" + data.Sex + 
                "',brithday='" + data.Brithday +
                "',class='" + data.Classid +
                "',address='" + data.Address +
                "',tel='" + data.Tel +
                "'"+"where sno='" + data.Sno + "'";

            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //删除
        private bool DeleteStudent(string sno)
        {
            string sql = "delete from studentinfo where sno='" + sno + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
    }
}

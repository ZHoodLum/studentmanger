using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
    public class StuGradeOperation
    {
        public bool InsertStuGrade(StuGradeData data)
        {
            string sql = "insert into stugrade(sno,cno,"
                + "gradepeacetime,gradeexpriment,gradelast,grade) values('"
                + data.Sno + "','" + data.Cno + "','" + data.Gradepeacetime + "','"
                + data.Gradeexpriment + "','" + data.Gradelast + "','"
                + data.Grade + "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
        //查询
        public System.Data.DataSet GetStuGrade(StuGradeData data)
        {
            string sql = "select * from stugrade where 1=1";
            string s = "";
            if (data.Sno != "" && data.Sno != null)
                s += " and sno='" + data.Sno + "'";
            if (data.Cno != "" && data.Cno != null)
                s += " and cno='" + data.Cno + "'";
            sql += s;
            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "StuGrade");
        }
        //修改
        public bool UpdateStuGrade(StuGradeData data)
        {
            string sql = "update StuGrade set sno='"
                + data.Sno + "',cno='" + data.Cno
                + "',gradepeacetime='" + data.Gradepeacetime
                + "',gradeexpriment='" + data.Gradeexpriment
                + "',gradelast='" + data.Gradelast
                + "',grade='" + data.Grade + "'"
                + " where sno='" + data.Sno + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
        //删除
        public bool DeleteStuGrade(string sno)
        {
            string sql = "delete from StuGrade where sno='" + sno + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
    }
}

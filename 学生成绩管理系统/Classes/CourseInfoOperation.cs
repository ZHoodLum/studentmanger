using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
    public class CourseInfoOperation
    {
        //插入
        public bool InsertCourseInfo(CourseInfoData data)
        {

            string sql = "insert into courseinfo(kcid,kcname,"
                 + "periodexpriment,periodteaching,credit,coursetype) values('"
                 + data.Kcid + "','" + data.Kcname + "','" + data.Periodexpriment + "','" 
                 + data.Periodteaching + "','" + data.Credit + "','" + data.Coursetype + "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //查询
        public System.Data.DataSet GetCourseInfo(CourseInfoData data)
        {
            string sql = "select * from courseinfo where 1=1";
            string s = "";
            if (data.Kcid != "" && data.Kcid != null)
                s += " and kcid ='" + data.Kcid + "'";
            if (data.Kcname != "" && data.Kcname != null)
                s += " and kcname='" + data.Kcname + "'";

            sql += s;
            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "stugradeinfo");
        }

        //修改
        public bool UpdateCourse(CourseInfoData data)
        {
            string sql = "update courseinfo set kcid='"
                + data.Kcid + "',kcname='" + data.Kcname
                + "',periodexpriment='" + data.Periodexpriment
                + "',periodteaching='" + data.Periodteaching
                + "',credit='" + data.Credit
                + "',coursetype='" + data.Coursetype + "'"

                + " where kcid='" + data.Kcid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //删除
        public bool DeleteCourse(string kcid)
        {
            string sql = "delete from courseinfo where KCid='" + kcid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
   public class ClassInfoOperation
    {
        //插入
        public bool InsertClassInfo(ClassInfoData data)
        {

            string sql = "insert into classinfo(classid,specialtyid,"
                 + "studentnumber,remark) values('"
                 + data.Classid + "','" + data.Specialtyid + "','" + data.Studentnumber + "','"
                 + data.Remark+ "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //查询
        public System.Data.DataSet GetClassInfo(ClassInfoData data)
        {
            string sql = "select * from classinfo where 1=1";
            string s = "";
            if (data.Classid != "" && data.Classid != null)
                s += " and classid ='" + data.Classid + "'";
            if (data.Specialtyid != "" && data.Specialtyid != null)
                s += " and specialtyid='" + data.Specialtyid + "'";
            sql += s;
            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "classinfo");
        }

        //修改
        public bool UpdateClass(ClassInfoData data)
        {
            string sql = "update classinfo set classid='"
                + data.Classid + "',Specialtyid='" + data.Specialtyid
                + "',studentnumber='" + data.Studentnumber
                + "',remark='" + data.Remark+ "'"
                + " where Classid='" + data.Classid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //删除
        public bool DeleteClass(string Classid)
        {
            string sql = "delete from classinfo where Classid='" +Classid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
    }
}

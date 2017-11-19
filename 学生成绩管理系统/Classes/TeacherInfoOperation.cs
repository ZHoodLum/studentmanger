using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
   public class TeacherInfoOperation
    {
        //插入
        public bool InsertTeacherInfo(TeacherInfoData data)
        {

            string sql = "insert into teacherinfo(teaid,teaname,"
                 + "teasex,teloffice,address,teabirthday) values('"
                 + data.Teaid + "','" + data.Teaname + "','" + data.Teasex + "','"
                 + data.Teloffice + "','" + data.Address + "','" + data.Teabirthday + "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //查询
        public System.Data.DataSet GetTeacherInfo(TeacherInfoData data)
        {
            string sql = "select * from teacherinfo where 1=1";
            string s = "";
            if (data.Teaid != "" && data.Teaid != null)
                s += " and teaid ='" + data.Teaid + "'";
            if (data.Teaname != "" && data.Teaname != null)
                s += " and teaname='" + data.Teaname + "'";
            if (data.Teasex != "" && data.Teasex != null)
                s += " and teasex='" + data.Teasex + "'";
            if (data.Teabirthday != "" && data.Teabirthday != null)
                s += " and teabirthday='" + data.Teabirthday + "'";

            sql += s;
            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "teacherinfo");
        }

        //修改
        public bool UpdateTeacher(TeacherInfoData data)
        {
            string sql = "update teacherinfo set teaid='"
                + data.Teaid + "',teaname='" + data.Teaname
                + "',teasex='" + data.Teasex
                + "',teloffice='" + data.Teloffice
                + "',address='" + data.Address
                + "',teabirthday='" + data.Teabirthday + "'"

                + " where Teaid='" + data.Teaid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //删除
        public bool DeleteTeacher(string Teaid)
        {
            string sql = "delete from teacherinfo where Teaid='" + Teaid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
    }
}

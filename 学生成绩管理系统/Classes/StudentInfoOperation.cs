using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
    public class StudentInfoOperation
    {
        public bool InsertStudentInfo(StudentInfoData data)
        {
            string sql = "insert into studentinfo(sno,sname,"
                + "sex,birthday,classid,tel,address) values('"
                + data.Sno + "','" + data.Sname + "','" + data.Sex + "','"
                + data.Birthday + "','" + data.Classid + "','" 
                + data.Tel+ "','" + data.Address + "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql); 
        }
        //查询
        public System.Data.DataSet GetStudentInfo(StudentInfoData data)
        {
            string sql = "select * from studentinfo where 1=1";
            string s = "";
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
        public bool UpdateStudent(StudentInfoData data)
        {
            string sql = "update studentinfo set sno='"
                +data.Sno+"',sname='"
                + data.Sname + "',sex='" + data.Sex
                + "',birthday='" + data.Birthday
                + "',classid='" + data.Classid
                + "',tel='" + data.Tel
                + "',address='" + data.Address + "'"
                + " where sno='" + data.Sno + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
        //删除
        public bool DeleteStudent(string sno)
        {
            string sql = "delete from studentinfo where sno='" + sno + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
    }
}

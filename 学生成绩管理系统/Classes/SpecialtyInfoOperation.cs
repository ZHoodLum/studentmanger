using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第二题.Classes
{
    public class SpecialtyInfoOperation
    {
        //插入
        public bool InsertSpecialtyInfo(SpecialtyInfoData data)
        {

            string sql = "insert into specialtyinfo(specialtyid,specialtymc) values('"
                 + data.Specialtyid + "','" + data.Specialtymc + "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //查询
        public System.Data.DataSet GetSpecialtyInfo(SpecialtyInfoData data)
        {
            string sql = "select * from specialtyinfo where 1=1";
            string s = "";
            if (data.Specialtyid != "" && data.Specialtyid != null)
                s += " and specialtyid ='" + data.Specialtyid + "'";
            if (data.Specialtymc != "" && data.Specialtymc != null)
                s += " and specialtymc='" + data.Specialtymc + "'";
            sql += s;
            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "specialtyinfo");
        }

        //修改
        public bool UpdateSpecialty(SpecialtyInfoData data)
        {
            string sql = "update specialtyinfo set specialtyid='"
                + data.Specialtyid + "',Specialtymc='" + data.Specialtymc
                + "' where Specialtyid = '" + data.Specialtyid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //删除
        public bool DeleteSpecialty(string Specialtyid)
        {
            string sql = "delete from Specialtyinfo where Specialtyid='" + Specialtyid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

    }
}

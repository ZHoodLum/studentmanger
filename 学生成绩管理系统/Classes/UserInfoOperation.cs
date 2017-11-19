
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 第二题.Classes
{
    public class UserInfoOperation
    {
        //插入
        public bool InsertUserInfo(UserInfoData data)
        {
           
           string sql = "insert into userinfo(userid,"
                + "userpwd,userlevel) values('"
                +data.Userid + "','" + data.Userpwd + "','" + data.Userlevel + "')";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //查询
        public DataSet GetUserInfo(UserInfoData data)
        {
            string sql = "select * from userinfo where 1=1";
            string s = "";
            if (data.Userid != "" && data.Userid != null)
                s += " and userid='" + data.Userid + "'";
            if (data.Userlevel != "" && data.Userlevel != null)
                s += " and userlevel='" + data.Userlevel + "'";

            sql += s;
            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "userinfo");
        }

        //修改
        public bool UpdateUser(UserInfoData data)
        {
            string sql = "update userinfo set userid='"
                + data.Userid + "',userpwd='" + data.Userpwd
                + "',userlevel='" + data.Userlevel + "'"
                + " where userid='" + data.Userid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }

        //删除
        public bool DeleteUser(string userid)
        {
            string sql = "delete from userinfo where userid='" + userid + "'";
            DataAccess da = new DataAccess();
            return da.ExecuteSQL(sql);
        }
        //未修改密码使用
        public static DataSet GetUserInfoAll(UserInfoData data)
        {
            string sql = "select * from userinfo where 1=1";
            string s = "";
            if (data.Userid != "" && data.Userid != null)
                s += " and userid='" + data.Userid + "'";
            if (data.Userlevel != "" && data.Userlevel != null)
                s += " and userlevel='" + data.Userlevel + "'";

            sql += s;
            DataAccess da = new DataAccess();
            return da.GetDataSet(sql, "userinfo");

        }
    }
}

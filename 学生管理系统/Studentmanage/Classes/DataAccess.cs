using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Studentmanage.Classes
{
        public class DataAccess
        {
            //配置数据库连接字符串
            //public static string ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            public static string ConnectionString = "data source=.;database=xscjgl;integrated security=true;";
            //执行SQL语句，返回Bool值，True为执行成功
            public bool ExecuteSQL(string sql)
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    cmd.Dispose();
                }
            }
            //执行SQL语句，返回SqlDataReader
            public SqlDataReader GetReader(string sql)
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = null;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    dr.Close();
                    con.Dispose();
                    cmd.Dispose();
                    throw new Exception(ex.ToString());
                }
                return dr;
            }
            //执行SQL语句，返回DataSet
            public DataSet GetDataSet(string sql, string tablename)
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                try
                {
                    da.Fill(ds, tablename);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    da.Dispose();
                }
                return ds;
            }
            //执行SQL语句并返回受影响的行数
            public int GetCount(string sql)
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count;
                }
                catch
                {
                    return 0;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    cmd.Dispose();
                }
            }
            //验证用户是否合法登录
            public bool CheckAdmin(string strname, string strpwd)
            {
                string sql;
                //strname=NameReplace(strname);
                sql = "select count(1) from UserInfo where Userid='" + strname + "' and Userpwd='" + strpwd + "'";
                if (GetCount(sql) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
	}

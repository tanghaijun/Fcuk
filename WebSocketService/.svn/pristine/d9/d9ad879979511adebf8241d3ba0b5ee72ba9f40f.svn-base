using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;


public class DBHelper
{
    public static DataTable GetTable(string sql)
    {
        DataSet ds = null;
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ToString()))
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
        }
        return ds.Tables[0];
    }
    public static DataTable GetTable(string sql, SqlParameter[] paras)
    {
        DataSet ds = null;
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ToString()))
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            if (paras != null)
                da.SelectCommand.Parameters.AddRange(paras);
            ds = new DataSet();
            da.Fill(ds);
        }
        return ds.Tables[0];
    }

    public static int ExecSql(string sql)
    {
        int result = 0;
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ToString()))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            result = cmd.ExecuteNonQuery();
        }
        return result;
    }
    public static int ExecSql(string sql, SqlParameter[] paras)
    {
        int result = 0;
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ToString()))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            result = cmd.ExecuteNonQuery();
        }
        return result;
    }
    /// <summary>
    /// 返回第一行第一列的数据
    /// </summary>
    /// <param name="sql">sql语句</param>
    /// <returns></returns>
    public static object ExecuteScalar(string sql)
    {
        object result = null;
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ToString()))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            result = cmd.ExecuteScalar();
        }
        return result;
    }
    /// <summary>
    /// 返回第一行第一列的数据
    /// </summary>
    /// <param name="sql">sql语句</param>
    /// <param name="paras">参数</param>
    /// <returns></returns>
    public static object ExecuteScalar(string sql, SqlParameter[] paras)
    {
        object result = null;
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ToString()))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            result = cmd.ExecuteScalar();
        }
        return result;
    }
}


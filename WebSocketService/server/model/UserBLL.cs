using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Connection.model
{
    public class UserBLL
    {
        public static bool CheckHasUser(string name, string pwd, out LoginUser user)
        {
            pwd = Common.getMD5String(pwd);
            string sql = "select * from Sys_UserInfo where loginname=@name and loginpwd=@pwd";
            SqlParameter[] p =
                {
                    new SqlParameter("@name",name),
                    new SqlParameter("@pwd",pwd)
                };
            var dt = DBHelper.GetTable(sql, p);
            if (dt.Rows.Count > 0)
            {
                user = CovertLoginUser(dt);
                return true;
            }
            else
            {
                user = null;
                return false;
            }
        }

        private static LoginUser CovertLoginUser(DataTable dt)
        {
            var user = new LoginUser();
            if (dt.Rows.Count > 0)
            {
                user.Id = (int)dt.Rows[0]["id"];
                user.LoginName = dt.Rows[0]["LoginName"].ToString();
                user.LoginPwd = dt.Rows[0]["LoginPwd"].ToString();
                user.NickName = dt.Rows[0]["NickName"].ToString();
                user.State = (int)dt.Rows[0]["State"];
                user.CreateTime = DateTime.Parse(dt.Rows[0]["CreateTime"].ToString());
            }
            return user;
        }
    }
}

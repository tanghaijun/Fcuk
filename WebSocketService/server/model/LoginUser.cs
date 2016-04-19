using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connection.model
{
    public class LoginUser
    {
        //Id, LoginName, LoginPwd, NickName, CreateTime, State
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string LoginPwd { get; set; }
        public string NickName { get; set; }
        public DateTime CreateTime { get; set; }
        public int State { get; set; }

    }
}

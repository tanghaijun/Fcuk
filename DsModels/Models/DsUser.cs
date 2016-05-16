using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsUser
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public string EnterpriseID { get; set; }
        public int Type { get; set; }
        public string PassportID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string MobilePhone { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int IsWork { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsEnterpriseBankCard
    {
        public string ID { get; set; }
        public string CardOwner { get; set; }
        public string CardNumber { get; set; }
        public string CardBank { get; set; }
        public int CardCityCode { get; set; }
        public string EnterpriseID { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
    }
}

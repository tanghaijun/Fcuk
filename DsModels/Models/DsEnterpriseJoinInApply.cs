using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsEnterpriseJoinInApply
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public string Data { get; set; }
        public int State { get; set; }
        public string Remark { get; set; }
        public string ApplyUserID { get; set; }
        public string EnterpriseName { get; set; }
        public int EnterpriseCityCode { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsEnterprise
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public string Name { get; set; }
        public int CityCode { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string EnterpriseJoinInApplyID { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

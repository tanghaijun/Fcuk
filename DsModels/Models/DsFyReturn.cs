using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsFyReturn
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public int State { get; set; }
        public int IsReturn { get; set; }
        public string ApplyRemark { get; set; }
        public string HandleRemark { get; set; }
        public string ApplyUserID { get; set; }
        public string HandleUserID { get; set; }
        public string FyOrderID { get; set; }
        public System.DateTime PayTime { get; set; }
        public System.DateTime ReturnTime { get; set; }
        public int Type { get; set; }
        public string CardOwner { get; set; }
        public string CardNumber { get; set; }
        public string CardBank { get; set; }
        public int CardCityCode { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

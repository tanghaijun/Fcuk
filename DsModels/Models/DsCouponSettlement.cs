using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsCouponSettlement
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public int State { get; set; }
        public string ApplyRemark { get; set; }
        public string HandleRemark { get; set; }
        public string ApplyUserID { get; set; }
        public string HandleUserID { get; set; }
        public string CardOwner { get; set; }
        public string CardNumber { get; set; }
        public string CardBank { get; set; }
        public int CardCityCode { get; set; }
        public decimal TotalOrderPrice { get; set; }
        public decimal TotalOrderCost { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

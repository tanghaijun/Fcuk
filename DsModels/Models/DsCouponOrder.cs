using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsCouponOrder
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public string CouponID { get; set; }
        public string BuyerUserID { get; set; }
        public string ConsultantUserID { get; set; }
        public string BoyUserID { get; set; }
        public decimal Price { get; set; }
        public int IsPay { get; set; }
        public System.DateTime PayTime { get; set; }
        public int IsRefund { get; set; }
        public System.DateTime RefundTime { get; set; }
        public int IsTrade { get; set; }
        public System.DateTime TradeTime { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime DeleteTime { get; set; }
        public int IsSettlement { get; set; }
        public System.DateTime SettlementTime { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int CostType { get; set; }
        public decimal CostRatio { get; set; }
        public decimal FixCost { get; set; }
        public string BuildingHouseID { get; set; }
        public string BuildingHouseName { get; set; }
        public string DynamicCode { get; set; }
        public System.DateTime DynamicCodeUpdateTime { get; set; }
        public string BuildingGroupID { get; set; }
        public string FyOrderID { get; set; }
        public string SimulateFyOrderID { get; set; }
        public string Source { get; set; }
    }
}

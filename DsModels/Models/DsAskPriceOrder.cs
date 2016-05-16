using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsAskPriceOrder
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public string AskPriceID { get; set; }
        public string BuyerUserID { get; set; }
        public string ConsultantUserID { get; set; }
        public decimal Price { get; set; }
        public int IsPay { get; set; }
        public System.DateTime PayTime { get; set; }
        public int IsReply { get; set; }
        public System.DateTime ReplyTime { get; set; }
        public string ReplyContentText { get; set; }
        public System.DateTime OverdueTime { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime DeleteTime { get; set; }
        public int IsSettlement { get; set; }
        public System.DateTime SettlementTime { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int CostType { get; set; }
        public decimal CostRatio { get; set; }
        public decimal FixCost { get; set; }
        public string BuildingGroupID { get; set; }
        public string IntentionBuildingGroupHouseTypeID { get; set; }
        public string IntentionBuildingGroupHouseTypeName { get; set; }
        public string IntentionBuildingFloorID { get; set; }
        public string IntentionBuildingFloorName { get; set; }
        public string IntentionBuildingID { get; set; }
        public string IntentionBuildingName { get; set; }
        public int IntentionPayType { get; set; }
        public string IntentionContentText { get; set; }
        public string IntentionBuildingHouseID { get; set; }
        public string IntentionBuildingHouseName { get; set; }
        public string BuildingHouseID { get; set; }
        public string BuildingHouseName { get; set; }
        public string FyOrderID { get; set; }
        public string Source { get; set; }
    }
}

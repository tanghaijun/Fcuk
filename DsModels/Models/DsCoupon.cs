using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsCoupon
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public string BuildingGroupID { get; set; }
        public string BuildingGroupNewcode { get; set; }
        public string Condition { get; set; }
        public string Title { get; set; }
        public string ContentText { get; set; }
        public string ShortTitle { get; set; }
        public string ShortContentText { get; set; }
        public decimal ShowPrice { get; set; }
        public decimal PayPrice { get; set; }
        public int TotalQuantity { get; set; }
        public int PayQuantity { get; set; }
        public int State { get; set; }
        public string EnterpriseID { get; set; }
        public string BuildingGroupHouseTypeID { get; set; }
        public string BuildingGroupHouseTypeName { get; set; }
        public string BuildingID { get; set; }
        public string BuildingName { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
    }
}

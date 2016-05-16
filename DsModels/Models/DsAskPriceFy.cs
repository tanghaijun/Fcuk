using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsAskPriceFy
    {
        public string ID { get; set; }
        public string BuildingHouseID { get; set; }
        public string BuildingHouseName { get; set; }
        public decimal BuildingHouseArea { get; set; }
        public decimal BuildingHouseSqmPrice { get; set; }
        public int BuildingHouseState { get; set; }
        public decimal Price { get; set; }
        public int PriceType { get; set; }
        public int LockInterval { get; set; }
        public string AskPriceOrderID { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
    }
}

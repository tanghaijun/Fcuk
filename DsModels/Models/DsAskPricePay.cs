using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsAskPricePay
    {
        public string ID { get; set; }
        public string AskPriceOrderID { get; set; }
        public int Type { get; set; }
        public string PayID { get; set; }
        public string PayData { get; set; }
        public int State { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
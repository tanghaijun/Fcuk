using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsAskPrice
    {
        public string ID { get; set; }
        public string BuildingGroupID { get; set; }
        public string Title { get; set; }
        public string ContentText { get; set; }
        public string ShortTitle { get; set; }
        public string ShortContentText { get; set; }
        public int IsSupport { get; set; }
        public decimal Cost { get; set; }
        public int DivideType { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

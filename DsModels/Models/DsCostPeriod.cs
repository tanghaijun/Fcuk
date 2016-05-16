using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsCostPeriod
    {
        public string ID { get; set; }
        public string BuildingGroupID { get; set; }
        public int BusinessType { get; set; }
        public int CostType { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public decimal CostRatio { get; set; }
        public decimal FixCost { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsBuildingFloor
    {
        public string ID { get; set; }
        public string BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string Name { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
        public string LouCengID { get; set; }
    }
}

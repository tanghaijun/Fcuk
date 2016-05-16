using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsBuilding
    {
        public string ID { get; set; }
        public string BuildingGroupID { get; set; }
        public string BuildingGroupName { get; set; }
        public string BuildingGroupNewcode { get; set; }
        public int BuildingGroupCityCode { get; set; }
        public string Name { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
        public string LouDongID { get; set; }
    }
}

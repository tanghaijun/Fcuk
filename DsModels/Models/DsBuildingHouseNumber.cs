using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsBuildingHouseNumber
    {
        public string ID { get; set; }
        public string BuildingUnitID { get; set; }
        public string BuildingUnitName { get; set; }
        public string BuildingGroupHouseTypeID { get; set; }
        public string BuildingGroupHouseTypeName { get; set; }
        public int Name { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
    }
}

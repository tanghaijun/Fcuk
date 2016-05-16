using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsBuildingHouse
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Area { get; set; }
        public decimal SqmPrice { get; set; }
        public string BuildingGroupHouseTypeID { get; set; }
        public string BuildingGroupHouseTypeName { get; set; }
        public int BuildingGroupHouseTypeShiCount { get; set; }
        public int BuildingGroupHouseTypeTingCount { get; set; }
        public int BuildingGroupHouseTypeWeiCount { get; set; }
        public int BuildingGroupHouseTypeChuCount { get; set; }
        public decimal BuildingGroupHouseTypeArea { get; set; }
        public string BuildingHouseNumberID { get; set; }
        public int BuildingHouseNumberName { get; set; }
        public string BuildingFloorID { get; set; }
        public string BuildingFloorName { get; set; }
        public string BuildingUnitID { get; set; }
        public string BuildingUnitName { get; set; }
        public string BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string BuildingGroupID { get; set; }
        public string BuildingGroupName { get; set; }
        public string BuildingGroupNewcode { get; set; }
        public int BuildingGroupCityCode { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
        public string FangYuanID { get; set; }
    }
}

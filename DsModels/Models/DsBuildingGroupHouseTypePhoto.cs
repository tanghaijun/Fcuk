using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsBuildingGroupHouseTypePhoto
    {
        public string ID { get; set; }
        public string BuildingGroupHouseTypeID { get; set; }
        public string Url { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
    }
}

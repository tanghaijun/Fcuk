using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsBuildingGroupToConsultant
    {
        public string BuildingGroupID { get; set; }
        public string UserID { get; set; }
        public int AskPriceDivideCount { get; set; }
        public string CreateUserID { get; set; }
    }
}

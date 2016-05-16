using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsFocusGroup
    {
        public string ID { get; set; }
        public string FocusID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string CreateUserID { get; set; }
        public System.DateTime SimulateStartTime { get; set; }
        public System.DateTime SimulateEndTime { get; set; }
    }
}

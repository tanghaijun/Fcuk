using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsLog
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}

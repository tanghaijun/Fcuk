using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsFyFollow
    {
        public string ID { get; set; }
        public string FyOrderID { get; set; }
        public string BoyUserID { get; set; }
        public int Type { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Remark { get; set; }
    }
}

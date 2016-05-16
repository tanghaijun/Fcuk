using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsUserCertificate
    {
        public string ID { get; set; }
        public string UserID { get; set; }
        public int Type { get; set; }
        public string Url { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

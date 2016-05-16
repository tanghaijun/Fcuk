using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsCouponFollow
    {
        public string ID { get; set; }
        public string CouponOrderID { get; set; }
        public string BoyUserID { get; set; }
        public int Type { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Remark { get; set; }
    }
}

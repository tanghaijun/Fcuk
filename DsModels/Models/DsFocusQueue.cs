using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsFocusQueue
    {
        public string ID { get; set; }
        public string UserID { get; set; }
        public string FocusID { get; set; }
        public string SequenceCode { get; set; }
        public int Type { get; set; }
        public string CouponOrderID { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string FyOrderID { get; set; }
        public string SimulateFyOrderID { get; set; }
    }
}

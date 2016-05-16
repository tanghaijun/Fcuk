using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsMessage
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string FromUserID { get; set; }
        public string ToUserID { get; set; }
        public string Title { get; set; }
        public string ContentText { get; set; }
        public int IsRead { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsFocu
    {
        public string ID { get; set; }
        public string SequenceCode { get; set; }
        public int FocusQueueType { get; set; }
        public System.DateTime FocusQueueStartTime { get; set; }
        public System.DateTime FocusQueueEndTime { get; set; }
        public System.DateTime OpenStartTime { get; set; }
        public System.DateTime OpenEndTime { get; set; }
        public System.DateTime SimulateOpenStartTime { get; set; }
        public System.DateTime SimulateOpenEndTime { get; set; }
        public string Title { get; set; }
        public string ContentText { get; set; }
        public string ShortTitle { get; set; }
        public string ShortContentText { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
        public string BuildingGroupID { get; set; }
    }
}

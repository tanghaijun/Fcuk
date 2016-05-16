using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsBuildingGroup
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Newcode { get; set; }
        public string Url { get; set; }
        public string WapUrl { get; set; }
        public int CityCode { get; set; }
        public string Title { get; set; }
        public string ContentText { get; set; }
        public string ShortTitle { get; set; }
        public string ShortContentText { get; set; }
        public int IsShow { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string CreateUserID { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsCity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public int IsOpen { get; set; }
    }
}

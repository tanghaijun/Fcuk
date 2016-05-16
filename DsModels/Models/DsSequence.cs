using System;
using System.Collections.Generic;

namespace DsModels.Models
{
    public partial class DsSequence
    {
        public string Type { get; set; }
        public System.DateTime DataTime { get; set; }
        public string Format { get; set; }
        public int CurrentValue { get; set; }
    }
}

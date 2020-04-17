using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class PlusResource
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? Maxunits { get; set; }
        public int? Work { get; set; }
        public string Projectuid { get; set; }
        public double? Cost { get; set; }
    }
}

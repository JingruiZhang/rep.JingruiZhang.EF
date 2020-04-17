using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BimcompFile
    {
        public string BcfMd5 { get; set; }
        public int? BcfSize { get; set; }
        public string BcfPath { get; set; }
    }
}

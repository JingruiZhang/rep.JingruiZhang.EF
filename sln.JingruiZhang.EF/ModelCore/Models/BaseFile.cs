using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseFile
    {
        public string BfGuid { get; set; }
        public string BfMd5 { get; set; }
        public string BfPath { get; set; }
        public string BfFilename { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class Errno
    {
        public string EnGuid { get; set; }
        public int EnErrno { get; set; }
        public string EnDescription { get; set; }
    }
}

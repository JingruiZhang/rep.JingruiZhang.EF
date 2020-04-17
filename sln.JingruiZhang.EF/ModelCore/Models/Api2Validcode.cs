using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class Api2Validcode
    {
        public string AvcGuid { get; set; }
        public string AvcSessionId { get; set; }
        public string AvcCode { get; set; }
        public int? AvcHadvalided { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class Api2Session
    {
        public string ApisessionId { get; set; }
        public string ApisessionToken { get; set; }
        public DateTime? ApisessionCurrenttime { get; set; }
        public string ApisessionCompanyid { get; set; }
        public string ApisessionUserid { get; set; }
    }
}

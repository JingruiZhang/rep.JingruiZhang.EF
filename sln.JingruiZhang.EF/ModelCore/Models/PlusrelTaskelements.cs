using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class PlusrelTaskelements
    {
        public string PteGuid { get; set; }
        public string PtePlanid { get; set; }
        public string PteTaskid { get; set; }
        public string PteElementids { get; set; }
        public DateTime? PteCreatetime { get; set; }
        public DateTime? PteUpdatetime { get; set; }
    }
}

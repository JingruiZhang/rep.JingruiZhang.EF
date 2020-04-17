using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseMaterialelements
    {
        public string BmeGuid { get; set; }
        public string BmeMaterialid { get; set; }
        public string BmeElementids { get; set; }
        public DateTime? BmeCreatetime { get; set; }
        public DateTime? BmeUpdatetime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseUserext
    {
        public string BueGuid { get; set; }
        public string BueUserId { get; set; }
        public int? BueExistspjcnt { get; set; }
        public int? BueTotalpjcnt { get; set; }
        public DateTime? BueUpdatetime { get; set; }
        public string BueUpdateuser { get; set; }
    }
}

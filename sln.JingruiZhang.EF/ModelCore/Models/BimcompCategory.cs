using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BimcompCategory
    {
        public string BccGuid { get; set; }
        public string BccOrganizeId { get; set; }
        public string BccName { get; set; }
        public string BccCode { get; set; }
        public int? BccCurlevelnumber { get; set; }
        public string BccDescription { get; set; }
        public DateTime? BccUpdatetime { get; set; }
    }
}

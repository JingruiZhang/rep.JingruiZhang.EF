using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class OrgUserorganize
    {
        public string OuoId { get; set; }
        public string OuoUserId { get; set; }
        public string OuoOrganizeId { get; set; }
        public int? OuoUserProjectCount { get; set; }
        public int? OuoUserProjectsCreated { get; set; }
    }
}

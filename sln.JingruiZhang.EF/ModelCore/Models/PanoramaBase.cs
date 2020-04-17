using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class PanoramaBase
    {
        public string PbGuid { get; set; }
        public string PbUrl { get; set; }
        public string PbName { get; set; }
        public DateTime PbUpdatetime { get; set; }
        public string PbOrganizeId { get; set; }
        public int PbIsdel { get; set; }
        public string PbGisinfo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseOrganizegis
    {
        public string BogGuid { get; set; }
        public string BogOrganizeId { get; set; }
        public double? BogLongitude { get; set; }
        public double? BogLatitude { get; set; }
        public double? BogHeight { get; set; }
    }
}

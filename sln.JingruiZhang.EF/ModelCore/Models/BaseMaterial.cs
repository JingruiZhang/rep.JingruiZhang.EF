using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseMaterial
    {
        public string BmGuid { get; set; }
        public string BmMaterialname { get; set; }
        public string BmMaterialcode { get; set; }
        public string BmMaterialmodel { get; set; }
        public double? BmMaterialcount { get; set; }
        public string BmMaterialunit { get; set; }
        public string BmMaterialfac { get; set; }
        public DateTime? BmPlanarrtime { get; set; }
        public string BcGuidMaterialtype { get; set; }
        public string BcGuidMaterialstatus { get; set; }
        public string BmExtjson { get; set; }
        public DateTime? BmUpdatetime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BimcompFamily
    {
        public string BcfaGuid { get; set; }
        public string BcfaName { get; set; }
        public string BcfaDescription { get; set; }
        public DateTime? BcfaUpdatetime { get; set; }
        public string BcfaFilelogicname { get; set; }
        public string BcfMd5 { get; set; }
        public string BcfImgmd5 { get; set; }
        public string BcfaRefguid { get; set; }
        public string BccGuid { get; set; }
    }
}

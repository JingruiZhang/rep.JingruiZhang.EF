using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseNewlog
    {
        public string BnlGuid { get; set; }
        public string BnlOriginUserId { get; set; }
        public string BnlOriginOrganizeId { get; set; }
        public string BnlType { get; set; }
        public string BnlModule { get; set; }
        public DateTime BnlDatetime { get; set; }
        public string BnlDesc { get; set; }
    }
}

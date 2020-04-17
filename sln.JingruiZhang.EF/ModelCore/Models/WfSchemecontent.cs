using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfSchemecontent
    {
        public string Id { get; set; }
        public string WfschemeInfoId { get; set; }
        public string SchemeVersion { get; set; }
        public string SchemeContent { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public string WfcShuntPairs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class MsgUser
    {
        public string MuGuid { get; set; }
        public string MmGuid { get; set; }
        public string UserId { get; set; }
        public string MuHasread { get; set; }
        public string MuHasalert { get; set; }
    }
}

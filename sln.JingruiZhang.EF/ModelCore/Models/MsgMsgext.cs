using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class MsgMsgext
    {
        public string MmeGuid { get; set; }
        public string MmGuid { get; set; }
        public string MmeExtdata { get; set; }
        public int? MmeILogAndMsgType { get; set; }
        public string MmeProjectId { get; set; }
    }
}

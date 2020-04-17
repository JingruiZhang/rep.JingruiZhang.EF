using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfDelegaterecord
    {
        public string Id { get; set; }
        public string WfdelegateRuleId { get; set; }
        public string FromUserId { get; set; }
        public string FromUserName { get; set; }
        public string ToUserId { get; set; }
        public string ToUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ProcessId { get; set; }
        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfFlowrecord
    {
        public string WfrId { get; set; }
        public string WfiId { get; set; }
        public string WfrPnodeId { get; set; }
        public string WfrCnodeId { get; set; }
        public DateTime? WfrCreatetime { get; set; }
        public string WfrOperator { get; set; }
        public string WfrOperateResult { get; set; }
        public string WfrComments { get; set; }
        public string WfrFormData { get; set; }
    }
}

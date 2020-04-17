using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfFlowinstance
    {
        public string WfiId { get; set; }
        public string ScId { get; set; }
        public string WfiTitle { get; set; }
        public string WfiCreateUser { get; set; }
        public DateTime? WfiCreateTime { get; set; }
        public string WfiActiveNodeIds { get; set; }
        public int? WfiStatus { get; set; }
        public DateTime? WfiUpdateTime { get; set; }
        public string WfiNextOperators { get; set; }
        public string WfiAllOperators { get; set; }
        public string WfiUniqueId { get; set; }
        public string WfiNexts { get; set; }
        public string WfiFormData { get; set; }
    }
}

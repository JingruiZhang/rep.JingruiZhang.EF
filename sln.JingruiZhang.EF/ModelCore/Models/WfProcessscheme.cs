using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfProcessscheme
    {
        public string Id { get; set; }
        public string SchemeContent { get; set; }
        public string WfschemeInfoId { get; set; }
        public string SchemeVersion { get; set; }
        public int ProcessType { get; set; }
        public string ModelId { get; set; }
        public string ViewpointId { get; set; }
        public string ElementId { get; set; }
        public string SpaceId { get; set; }
    }
}

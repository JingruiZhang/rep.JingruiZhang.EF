using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class OperLog
    {
        public string OlGuid { get; set; }
        public string OlObjId { get; set; }
        public DateTime OlDatetime { get; set; }
        public string OlOperId { get; set; }
        public string OlContent { get; set; }
        public string OlType { get; set; }
    }
}

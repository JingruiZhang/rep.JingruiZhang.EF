using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseMaterialrecord
    {
        public string BmrGuid { get; set; }
        public string BmrUserId { get; set; }
        public string BmrUserName { get; set; }
        public string BmrOperDescription { get; set; }
        public string BmrOperItems { get; set; }
        public DateTime? BmrOperdate { get; set; }
        public string BmGuid { get; set; }
    }
}

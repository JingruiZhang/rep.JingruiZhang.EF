using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseModuleforminstance
    {
        public string FormInstanceId { get; set; }
        public string FormId { get; set; }
        public string FormInstanceJson { get; set; }
        public string ObjectId { get; set; }
        public int? SortCode { get; set; }
        public string Description { get; set; }
    }
}

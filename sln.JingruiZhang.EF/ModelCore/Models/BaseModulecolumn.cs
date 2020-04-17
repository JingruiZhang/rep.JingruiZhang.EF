using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseModulecolumn
    {
        public string ModuleColumnId { get; set; }
        public string ModuleId { get; set; }
        public string ParentId { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public int? SortCode { get; set; }
        public string Description { get; set; }
    }
}

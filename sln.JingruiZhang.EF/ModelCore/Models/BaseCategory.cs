using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseCategory
    {
        public string BcGuid { get; set; }
        public string BcCategoryname { get; set; }
        public string BcCategorytype { get; set; }
        public string BcOrganizeId { get; set; }
        public DateTime? BcCreatetime { get; set; }
        public string BcExtjson { get; set; }
    }
}

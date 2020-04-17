using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseCompanydata
    {
        public string CompanydataId { get; set; }
        public string OrganizeId { get; set; }
        public string JsonData { get; set; }
        public string CreateDate { get; set; }
        public string ModifyDate { get; set; }
    }
}

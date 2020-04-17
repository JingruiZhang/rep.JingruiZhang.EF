using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseCoderuleseed
    {
        public string RuleSeedId { get; set; }
        public string RuleId { get; set; }
        public string UserId { get; set; }
        public int? SeedValue { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}

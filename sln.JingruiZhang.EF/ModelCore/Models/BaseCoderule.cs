using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseCoderule
    {
        public string RuleId { get; set; }
        public string ModuleId { get; set; }
        public string Module { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public int? Mode { get; set; }
        public string CurrentNumber { get; set; }
        public string RuleFormatJson { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseRole
    {
        public string RoleId { get; set; }
        public string OrganizeId { get; set; }
        public int? Category { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public int? IsPublic { get; set; }
        public DateTime? OverdueTime { get; set; }
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
        public bool? IsProjectManager { get; set; }
        public string TemplateId { get; set; }
    }
}

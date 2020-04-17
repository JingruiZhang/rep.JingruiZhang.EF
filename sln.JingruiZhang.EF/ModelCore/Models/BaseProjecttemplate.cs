using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseProjecttemplate
    {
        public string TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string OrganizeId { get; set; }
        public bool? IsDel { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}

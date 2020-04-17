using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfSchemeinfo
    {
        public string Id { get; set; }
        public string SchemeCode { get; set; }
        public string SchemeName { get; set; }
        public string SchemeType { get; set; }
        public string SchemeVersion { get; set; }
        public string SchemeCanUser { get; set; }
        public int? FrmType { get; set; }
        public int? AuthorizeType { get; set; }
        public int? SortCode { get; set; }
        public int DeleteMark { get; set; }
        public int EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public string SchemeTemplateType { get; set; }
        public string DependentCategory { get; set; }
        public string TemplateId { get; set; }
    }
}

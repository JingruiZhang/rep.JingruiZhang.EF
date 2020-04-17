using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WechatApp
    {
        public string AppId { get; set; }
        public string AppLogo { get; set; }
        public string AppName { get; set; }
        public int? AppType { get; set; }
        public string Description { get; set; }
        public string AppUrl { get; set; }
        public string RedirectDomain { get; set; }
        public string MenuJson { get; set; }
        public int? IsReportUser { get; set; }
        public int? IsReportenter { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}

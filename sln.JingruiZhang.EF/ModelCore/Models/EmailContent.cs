using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class EmailContent
    {
        public string ContentId { get; set; }
        public string CategoryId { get; set; }
        public string ParentId { get; set; }
        public string Theme { get; set; }
        public string ThemeColor { get; set; }
        public string EmailContent1 { get; set; }
        public int? EmailType { get; set; }
        public string SenderId { get; set; }
        public string SenderName { get; set; }
        public DateTime? SenderTime { get; set; }
        public int? IsHighlight { get; set; }
        public string SendPriority { get; set; }
        public int? IsSmsReminder { get; set; }
        public int? IsReceipt { get; set; }
        public string AddresssHtml { get; set; }
        public string CopysendHtml { get; set; }
        public string BccsendHtml { get; set; }
        public int? SendState { get; set; }
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

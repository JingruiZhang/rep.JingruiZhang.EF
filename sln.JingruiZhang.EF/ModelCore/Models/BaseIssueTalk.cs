using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseIssueTalk
    {
        public string IssueTalkId { get; set; }
        public string IssueId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string ContentType { get; set; }
        public int? DeleteMark { get; set; }
        public string UserOfUnRead { get; set; }
        public string IssuePtalkId { get; set; }
        public string CommentPatchGuid { get; set; }
    }
}

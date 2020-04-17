using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseIssueUser
    {
        public string IssueUserId { get; set; }
        public string IssueId { get; set; }
        public string UserId { get; set; }
        public string Iutype { get; set; }
        public int? IsRead { get; set; }
    }
}

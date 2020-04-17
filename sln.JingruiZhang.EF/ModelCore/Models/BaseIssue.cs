using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseIssue
    {
        public string IssueId { get; set; }
        public string ProjectId { get; set; }
        public string ModelId { get; set; }
        public string ViewpointId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string IssueStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime EndDate { get; set; }
        public sbyte? IsPublic { get; set; }
        public string IssueTypeId { get; set; }
        public int? DeleteMark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseNews
    {
        public string NewsId { get; set; }
        public int? TypeId { get; set; }
        public string ParentId { get; set; }
        public string Category { get; set; }
        public string FullHead { get; set; }
        public string FullHeadColor { get; set; }
        public string BriefHead { get; set; }
        public string AuthorName { get; set; }
        public string CompileName { get; set; }
        public string TagWord { get; set; }
        public string Keyword { get; set; }
        public string SourceName { get; set; }
        public string SourceAddress { get; set; }
        public string NewsContent { get; set; }
        public int? Pv { get; set; }
        public DateTime? ReleaseTime { get; set; }
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

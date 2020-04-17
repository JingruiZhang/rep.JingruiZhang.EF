using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseRelation
    {
        public string RelationId { get; set; }
        public string SourceId { get; set; }
        public string SourceType { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }
        public string CreateDate { get; set; }
        public string CreateUser { get; set; }
        public int? BrDeleteMark { get; set; }
    }
}

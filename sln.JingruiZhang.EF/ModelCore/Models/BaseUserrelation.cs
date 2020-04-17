using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseUserrelation
    {
        public string UserRelationId { get; set; }
        public string UserId { get; set; }
        public int? Category { get; set; }
        public string ObjectId { get; set; }
        public int? IsDefault { get; set; }
        public int? SortCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

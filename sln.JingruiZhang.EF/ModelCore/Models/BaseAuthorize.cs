using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseAuthorize
    {
        public string AuthorizeId { get; set; }
        public int? Category { get; set; }
        public string ObjectId { get; set; }
        public int? ItemType { get; set; }
        public string ItemId { get; set; }
        public int? SortCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

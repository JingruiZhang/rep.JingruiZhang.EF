using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseDataitemdetail
    {
        public string ItemDetailId { get; set; }
        public string ItemId { get; set; }
        public string ParentId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public string QuickQuery { get; set; }
        public string SimpleSpelling { get; set; }
        public int? IsDefault { get; set; }
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
        public string FlagId { get; set; }
        public string Category { get; set; }
    }
}

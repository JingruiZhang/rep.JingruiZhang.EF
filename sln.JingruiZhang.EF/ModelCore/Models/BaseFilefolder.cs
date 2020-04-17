using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseFilefolder
    {
        public string FolderId { get; set; }
        public string ParentId { get; set; }
        public string FolderType { get; set; }
        public string FolderName { get; set; }
        public int? IsShare { get; set; }
        public string ShareLink { get; set; }
        public int? ShareCode { get; set; }
        public DateTime? ShareTime { get; set; }
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

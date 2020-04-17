using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseFileinfo
    {
        public string FileId { get; set; }
        public string FolderId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string FileExtensions { get; set; }
        public string FileType { get; set; }
        public int? IsShare { get; set; }
        public string ShareLink { get; set; }
        public int? ShareCode { get; set; }
        public DateTime? ShareTime { get; set; }
        public int? DownloadCount { get; set; }
        public int? IsTop { get; set; }
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

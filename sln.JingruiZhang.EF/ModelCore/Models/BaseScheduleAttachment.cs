using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseScheduleAttachment
    {
        public string Id { get; set; }
        public string ScheduleId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string FileExtensions { get; set; }
        public string FileType { get; set; }
        public int? IsShare { get; set; }
        public string FileVersionId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateUserId { get; set; }
        public int? IsDel { get; set; }
    }
}

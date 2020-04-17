using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ApiExamineattachment
    {
        public string ExamineAttachmentId { get; set; }
        public string ExamineId { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentUrl { get; set; }
        public DateTime? UploadDate { get; set; }
        public int? CheckFlag { get; set; }
        public int? IsDel { get; set; }
    }
}

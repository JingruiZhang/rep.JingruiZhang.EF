using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseFileinfoVersion
    {
        public string FileInfoVersionId { get; set; }
        public string FileId { get; set; }
        public int FileVersion { get; set; }
        public string FileSize { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

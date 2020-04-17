using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseTemplateFolder
    {
        public string TemplatefolderId { get; set; }
        public string TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string FolderJson { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ApiDrawposinfo
    {
        public string Gid { get; set; }
        public string FileId { get; set; }
        public int? PosX { get; set; }
        public int? PosY { get; set; }
        public string OpId { get; set; }
        public string OpUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ExamineId { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public string Pixel2Mx { get; set; }
        public string Pixel2My { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public int? IsDel { get; set; }
    }
}

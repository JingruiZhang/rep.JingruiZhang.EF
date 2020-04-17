using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ExamCategory
    {
        public string EcGuid { get; set; }
        public string EcOrganizeId { get; set; }
        public string EcType { get; set; }
        public string EcName { get; set; }
        public string EcCode { get; set; }
        public int EcCurlevelnumber { get; set; }
        public string EcElementids { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfProcessinstance
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string CustomName { get; set; }
        public string ActivityId { get; set; }
        public int ActivityType { get; set; }
        public string ActivityName { get; set; }
        public string PreviousId { get; set; }
        public string ProcessSchemeId { get; set; }
        public string SchemeType { get; set; }
        public int? FrmType { get; set; }
        public int EnabledMark { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public int? Level { get; set; }
        public string Description { get; set; }
        public int? IsFinish { get; set; }
        public string MakerList { get; set; }
        public string BimcomposerId { get; set; }
    }
}

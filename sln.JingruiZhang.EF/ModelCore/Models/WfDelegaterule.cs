using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfDelegaterule
    {
        public string Id { get; set; }
        public string ToUserId { get; set; }
        public string ToUserName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? EnabledMark { get; set; }
        public string Description { get; set; }
    }
}

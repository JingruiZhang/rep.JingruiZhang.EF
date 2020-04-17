using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfProcessoperationhistory
    {
        public string Id { get; set; }
        public string ProcessId { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

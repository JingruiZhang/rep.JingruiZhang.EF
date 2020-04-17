using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseMessagequeue
    {
        public string MessageQueueId { get; set; }
        public string MessageContent { get; set; }
        public string ReceiverContact { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public bool? IsDel { get; set; }
        public bool? IsPushed { get; set; }
        public int? Category { get; set; }
    }
}

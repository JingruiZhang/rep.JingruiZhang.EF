using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseScheduleParticipant
    {
        public string OrganizedParticipantId { get; set; }
        public string ScheduleId { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime Updated { get; set; }
        public int Removed { get; set; }
    }
}

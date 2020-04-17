using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class Api2Invite
    {
        public string InvGuid { get; set; }
        public string InvEmail { get; set; }
        public string InvInvitecode { get; set; }
        public DateTime? InvCreatedate { get; set; }
        public DateTime? InvDeadlinedate { get; set; }
        public string InvRoleId { get; set; }
    }
}

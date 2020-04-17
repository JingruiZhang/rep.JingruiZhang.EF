using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class EmailAddressee
    {
        public string AddresseeId { get; set; }
        public string ContentId { get; set; }
        public string CategoryId { get; set; }
        public string RecipientId { get; set; }
        public string RecipientName { get; set; }
        public int? RecipientState { get; set; }
        public int? IsRead { get; set; }
        public int? ReadCount { get; set; }
        public DateTime? ReadDate { get; set; }
        public int? IsHighlight { get; set; }
        public int? Backlog { get; set; }
        public int? DeleteMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}

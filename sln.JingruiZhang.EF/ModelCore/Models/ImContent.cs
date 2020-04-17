using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ImContent
    {
        public string ContentId { get; set; }
        public int? IsGroup { get; set; }
        public string SendId { get; set; }
        public string ToId { get; set; }
        public string MsgContent { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

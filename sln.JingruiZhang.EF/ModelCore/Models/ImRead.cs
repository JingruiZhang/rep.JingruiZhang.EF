using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ImRead
    {
        public string ReadId { get; set; }
        public string ContentId { get; set; }
        public string UserId { get; set; }
        public string SendId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public int? ReadStatus { get; set; }
    }
}

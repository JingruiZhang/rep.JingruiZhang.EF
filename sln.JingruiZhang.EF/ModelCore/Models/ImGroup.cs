using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ImGroup
    {
        public string GroupId { get; set; }
        public string FullName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

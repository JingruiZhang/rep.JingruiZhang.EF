using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ImUsergroup
    {
        public string UserGroupId { get; set; }
        public string GroupId { get; set; }
        public string UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

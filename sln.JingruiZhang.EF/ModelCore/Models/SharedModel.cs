using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class SharedModel
    {
        public string ShmGuid { get; set; }
        public string ShmSessionId { get; set; }
        public string ShmProjectid { get; set; }
        public string ShmModelid { get; set; }
        public string ShmJson { get; set; }
        public DateTime? ShmCreatedate { get; set; }
        public string ShmPwd { get; set; }
        public bool? ShmHaspwd { get; set; }
        public string ShmModelversion { get; set; }
        public string ShmCreateUserId { get; set; }
        public string ShmOriginpwd { get; set; }
    }
}

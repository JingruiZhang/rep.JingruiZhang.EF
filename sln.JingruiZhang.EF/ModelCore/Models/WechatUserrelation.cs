using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WechatUserrelation
    {
        public string UserRelationId { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public int? WeChatDeptId { get; set; }
        public string UserId { get; set; }
        public string SyncState { get; set; }
        public string SyncLog { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

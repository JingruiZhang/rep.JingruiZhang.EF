using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WechatDeptrelation
    {
        public string DeptRelationId { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public int? WeChatDeptId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}

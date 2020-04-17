using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class WfFrmmain
    {
        public string FrmMainId { get; set; }
        public string FrmCode { get; set; }
        public string FrmName { get; set; }
        public string FrmType { get; set; }
        public string FrmDbId { get; set; }
        public string FrmTable { get; set; }
        public int? IsSystemTable { get; set; }
        public string FrmTableId { get; set; }
        public string FrmContent { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public string FrmExtrajson { get; set; }
    }
}

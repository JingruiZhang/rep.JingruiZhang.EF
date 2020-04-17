using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseDatabasebackup
    {
        public string DatabaseBackupId { get; set; }
        public string DatabaseLinkId { get; set; }
        public string ParentId { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public int? ExecuteMode { get; set; }
        public string ExecuteTime { get; set; }
        public string BackupPath { get; set; }
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
    }
}

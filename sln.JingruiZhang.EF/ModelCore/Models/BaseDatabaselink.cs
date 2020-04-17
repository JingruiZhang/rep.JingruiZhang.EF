using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseDatabaselink
    {
        public string DatabaseLinkId { get; set; }
        public string ServerAddress { get; set; }
        public string Dbname { get; set; }
        public string Dbalias { get; set; }
        public string DbType { get; set; }
        public string Version { get; set; }
        public string DbConnection { get; set; }
        public int? Desencrypt { get; set; }
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

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class RptTemp
    {
        public string TempId { get; set; }
        public string FullName { get; set; }
        public string EnCode { get; set; }
        public string TempType { get; set; }
        public string Description { get; set; }
        public string ParamJson { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public string TempCategory { get; set; }
    }
}

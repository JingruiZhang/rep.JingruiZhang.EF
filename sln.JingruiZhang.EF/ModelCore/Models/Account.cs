using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class Account
    {
        public string AccountId { get; set; }
        public string MobileCode { get; set; }
        public string SecurityCode { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string FullName { get; set; }
        public DateTime? RegisterTime { get; set; }
        public DateTime? ExpireTime { get; set; }
        public string Ipaddress { get; set; }
        public string IpaddressName { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastVisit { get; set; }
        public int? LogOnCount { get; set; }
        public int? AmountCount { get; set; }
        public sbyte? IsResetPwd { get; set; }
    }
}

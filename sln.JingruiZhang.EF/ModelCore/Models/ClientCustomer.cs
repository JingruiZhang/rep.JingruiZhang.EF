using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientCustomer
    {
        public string CustomerId { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string CustIndustryId { get; set; }
        public string CustTypeId { get; set; }
        public string CustLevelId { get; set; }
        public string CustDegreeId { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Qq { get; set; }
        public string Email { get; set; }
        public string Wechat { get; set; }
        public string Hobby { get; set; }
        public string LegalPerson { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanySite { get; set; }
        public string CompanyDesc { get; set; }
        public string TraceUserId { get; set; }
        public string TraceUserName { get; set; }
        public DateTime? AlertDateTime { get; set; }
        public int? AlertState { get; set; }
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

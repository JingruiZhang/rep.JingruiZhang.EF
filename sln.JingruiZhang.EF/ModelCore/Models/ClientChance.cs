using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientChance
    {
        public string ChanceId { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public string SourceId { get; set; }
        public string StageId { get; set; }
        public decimal? SuccessRate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Profit { get; set; }
        public string ChanceTypeId { get; set; }
        public decimal? SaleCost { get; set; }
        public DateTime? DealDate { get; set; }
        public int? IsToCustom { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNatureId { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanySite { get; set; }
        public string CompanyDesc { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Contacts { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Qq { get; set; }
        public string Email { get; set; }
        public string Wechat { get; set; }
        public string Hobby { get; set; }
        public string TraceUserId { get; set; }
        public string TraceUserName { get; set; }
        public int? ChanceState { get; set; }
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

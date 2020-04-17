using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseOrganize
    {
        public string OrganizeId { get; set; }
        public int? Category { get; set; }
        public string ParentId { get; set; }
        public string EnCode { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Nature { get; set; }
        public string OuterPhone { get; set; }
        public string InnerPhone { get; set; }
        public string Fax { get; set; }
        public string Postalcode { get; set; }
        public string Email { get; set; }
        public string ManagerId { get; set; }
        public string Manager { get; set; }
        public string ProvinceId { get; set; }
        public string CityId { get; set; }
        public string CountyId { get; set; }
        public string Address { get; set; }
        public string WebAddress { get; set; }
        public DateTime? FoundedTime { get; set; }
        public string BusinessScope { get; set; }
        public int? Layer { get; set; }
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
        public string MachineCode { get; set; }
        public string CertificateCode { get; set; }
        public int? ExistsActivityTotal { get; set; }
        public int? ExistsArchiveTotal { get; set; }
        public string DataFrom { get; set; }
        public int? IsSample { get; set; }
    }
}

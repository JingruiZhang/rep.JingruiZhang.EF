using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseDepartment
    {
        public string DepartmentId { get; set; }
        public string OrganizeId { get; set; }
        public string ParentId { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Nature { get; set; }
        public string ManagerId { get; set; }
        public string Manager { get; set; }
        public string OuterPhone { get; set; }
        public string InnerPhone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
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
    }
}

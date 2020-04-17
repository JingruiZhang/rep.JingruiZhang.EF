using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseUser
    {
        public string UserId { get; set; }
        public string EnCode { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Secretkey { get; set; }
        public string RealName { get; set; }
        public string NickName { get; set; }
        public string HeadIcon { get; set; }
        public string QuickQuery { get; set; }
        public string SimpleSpelling { get; set; }
        public int? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Oicq { get; set; }
        public string WeChat { get; set; }
        public string Msn { get; set; }
        public string ManagerId { get; set; }
        public string Manager { get; set; }
        public string OrganizeId { get; set; }
        public string DepartmentId { get; set; }
        public string RoleId { get; set; }
        public string DutyId { get; set; }
        public string DutyName { get; set; }
        public string PostId { get; set; }
        public string PostName { get; set; }
        public string WorkGroupId { get; set; }
        public int? SecurityLevel { get; set; }
        public int? UserOnLine { get; set; }
        public string OpenId { get; set; }
        public string Question { get; set; }
        public string AnswerQuestion { get; set; }
        public int? CheckOnLine { get; set; }
        public DateTime? AllowStartTime { get; set; }
        public DateTime? AllowEndTime { get; set; }
        public DateTime? LockStartDate { get; set; }
        public DateTime? LockEndDate { get; set; }
        public DateTime? FirstVisit { get; set; }
        public DateTime? PreviousVisit { get; set; }
        public DateTime? LastVisit { get; set; }
        public int? LogOnCount { get; set; }
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
        public string UserType { get; set; }
        public string DataFrom { get; set; }
    }
}

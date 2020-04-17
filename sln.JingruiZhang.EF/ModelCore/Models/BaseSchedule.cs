using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseSchedule
    {
        public string ScheduleId { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleContent { get; set; }
        public string Category { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndTime { get; set; }
        public int? Early { get; set; }
        public int? IsMailAlert { get; set; }
        public int? IsMobileAlert { get; set; }
        public int? IsWeChatAlert { get; set; }
        public int? ScheduleState { get; set; }
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
        public string OrganizeId { get; set; }
        public string TaskTypeId { get; set; }
        public int Security { get; set; }
    }
}

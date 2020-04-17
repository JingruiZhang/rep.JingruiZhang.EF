using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseFiltertime
    {
        public string FilterTimeId { get; set; }
        public string ObjectType { get; set; }
        public string ObjectId { get; set; }
        public int? VisitType { get; set; }
        public string WeekDay1 { get; set; }
        public string WeekDay2 { get; set; }
        public string WeekDay3 { get; set; }
        public string WeekDay4 { get; set; }
        public string WeekDay5 { get; set; }
        public string WeekDay6 { get; set; }
        public string WeekDay7 { get; set; }
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

using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientTrailrecord
    {
        public string TrailId { get; set; }
        public int? ObjectSort { get; set; }
        public string ObjectId { get; set; }
        public string TrackContent { get; set; }
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
        public string TrackTypeId { get; set; }
    }
}

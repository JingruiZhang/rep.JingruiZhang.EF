using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseOrganizeextend
    {
        public string OrganizeExtendId { get; set; }
        public string OrganizeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public string ThumbnailUrl { get; set; }
        public string BimcomposerId { get; set; }
        public sbyte? IsDel { get; set; }
        public sbyte? IsPublic { get; set; }
        public sbyte? IsPersonal { get; set; }
        public string OwnerUnit { get; set; }
        public string ConstructionUnit { get; set; }
        public string DesignUnit { get; set; }
        public DateTime? ProjectApprovalDate { get; set; }
    }
}

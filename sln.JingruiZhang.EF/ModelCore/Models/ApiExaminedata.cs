using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ApiExaminedata
    {
        public string ExamineId { get; set; }
        public string ProjectId { get; set; }
        public string ModelId { get; set; }
        public string ViewId { get; set; }
        public string ViewpointId { get; set; }
        public string LinkType { get; set; }
        public string LinkId { get; set; }
        public string Principal { get; set; }
        public string PrincipalId { get; set; }
        public string RelationMember { get; set; }
        public string RelationMemberId { get; set; }
        public string Examiner { get; set; }
        public string ExaminerId { get; set; }
        public DateTime? ExamineDate { get; set; }
        public string ExamineRemark { get; set; }
        public string ExamineResult { get; set; }
        public DateTime? RectificateDate { get; set; }
        public string FloorId { get; set; }
        public string FloorName { get; set; }
        public string FlowPhaseId { get; set; }
        public string FlowPhase { get; set; }
        public string Professional { get; set; }
        public string Category { get; set; }
        public string Placement { get; set; }
        public string FirstCheckerId { get; set; }
        public string FirstCheckerName { get; set; }
        public DateTime? FirstCheckDate { get; set; }
        public string FirstCheckRemark { get; set; }
        public string FirstCheckResult { get; set; }
        public string SecondCheckerId { get; set; }
        public string SecondCheckerName { get; set; }
        public DateTime? SecondCheckDate { get; set; }
        public string SecondCheckRemark { get; set; }
        public string SecondCheckResult { get; set; }
        public string ConstructUnit { get; set; }
        public string ConstructUnitId { get; set; }
        public string SubConstructUnit { get; set; }
        public string SubConstructUnitId { get; set; }
        public string Subdivisional { get; set; }
        public string SubdivisionalId { get; set; }
        public string VerifyBatch { get; set; }
        public string VerifyBatchId { get; set; }
        public string Axis { get; set; }
        public string AxisId { get; set; }
        public string ConstructionTeam { get; set; }
        public string ConstructionTeamId { get; set; }
        public int? IsDel { get; set; }
        public string ProfessionalId { get; set; }
        public string CategoryId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Title { get; set; }
    }
}

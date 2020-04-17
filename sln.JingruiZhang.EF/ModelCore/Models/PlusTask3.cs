using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class PlusTask3
    {
        public string Uid { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public int? Duration { get; set; }
        public int? Work { get; set; }
        public int? Percentcomplete { get; set; }
        public int? Manual { get; set; }
        public int? Weight { get; set; }
        public int? Constrainttype { get; set; }
        public DateTime? Constraintdate { get; set; }
        public int? Milestone { get; set; }
        public int? Summary { get; set; }
        public int? Critical { get; set; }
        public int? Priority { get; set; }
        public string Notes { get; set; }
        public string Department { get; set; }
        public string Principal { get; set; }
        public string Predecessorlink { get; set; }
        public int? Fixeddate { get; set; }
        public string Parenttaskuid { get; set; }
        public string Projectuid { get; set; }
        public DateTime? Actualstart { get; set; }
        public DateTime? Actualfinish { get; set; }
        public int? Actualduration { get; set; }
        public string Assignments { get; set; }
        public string Wbs { get; set; }
        public int? Critical2 { get; set; }
    }
}

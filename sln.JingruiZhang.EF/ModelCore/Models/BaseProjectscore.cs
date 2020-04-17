using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class BaseProjectscore
    {
        public string ProjectScoreId { get; set; }
        public string OrganizeId { get; set; }
        public int Score { get; set; }
        public string UserId { get; set; }
        public int ModelCovery { get; set; }
        public int ModelButter { get; set; }
        public int ModelPara { get; set; }
        public int ModelComplex { get; set; }
        public int ModelBulid { get; set; }
    }
}

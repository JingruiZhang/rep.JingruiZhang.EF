//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelNet45
{
    using System;
    using System.Collections.Generic;
    
    public partial class wf_processinstance
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string CustomName { get; set; }
        public string ActivityId { get; set; }
        public int ActivityType { get; set; }
        public string ActivityName { get; set; }
        public string PreviousId { get; set; }
        public string ProcessSchemeId { get; set; }
        public string SchemeType { get; set; }
        public Nullable<int> FrmType { get; set; }
        public int EnabledMark { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public Nullable<int> Level { get; set; }
        public string Description { get; set; }
        public Nullable<int> IsFinish { get; set; }
        public string MakerList { get; set; }
        public string BIMComposerID { get; set; }
    }
}

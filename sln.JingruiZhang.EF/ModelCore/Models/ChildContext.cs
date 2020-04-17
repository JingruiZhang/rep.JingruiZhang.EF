using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModelCore.Models
{
    public partial class ChildContext : DbContext
    {
        public ChildContext()
        {
        }

        public ChildContext(DbContextOptions<ChildContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Api2Invite> Api2Invite { get; set; }
        public virtual DbSet<Api2Recycles> Api2Recycles { get; set; }
        public virtual DbSet<Api2Session> Api2Session { get; set; }
        public virtual DbSet<Api2Suscribe> Api2Suscribe { get; set; }
        public virtual DbSet<Api2Validcode> Api2Validcode { get; set; }
        public virtual DbSet<ApiDrawposinfo> ApiDrawposinfo { get; set; }
        public virtual DbSet<ApiExamineattachment> ApiExamineattachment { get; set; }
        public virtual DbSet<ApiExaminedata> ApiExaminedata { get; set; }
        public virtual DbSet<ApiExaminedataextend> ApiExaminedataextend { get; set; }
        public virtual DbSet<ApiExaminedatatype> ApiExaminedatatype { get; set; }
        public virtual DbSet<AuthRolephase> AuthRolephase { get; set; }
        public virtual DbSet<BaseArea> BaseArea { get; set; }
        public virtual DbSet<BaseAuthorize> BaseAuthorize { get; set; }
        public virtual DbSet<BaseAuthorizedata> BaseAuthorizedata { get; set; }
        public virtual DbSet<BaseCategory> BaseCategory { get; set; }
        public virtual DbSet<BaseCoderule> BaseCoderule { get; set; }
        public virtual DbSet<BaseCoderuleseed> BaseCoderuleseed { get; set; }
        public virtual DbSet<BaseCompanydata> BaseCompanydata { get; set; }
        public virtual DbSet<BaseDatabasebackup> BaseDatabasebackup { get; set; }
        public virtual DbSet<BaseDatabaselink> BaseDatabaselink { get; set; }
        public virtual DbSet<BaseDataitem> BaseDataitem { get; set; }
        public virtual DbSet<BaseDataitemdetail> BaseDataitemdetail { get; set; }
        public virtual DbSet<BaseDepartment> BaseDepartment { get; set; }
        public virtual DbSet<BaseFile> BaseFile { get; set; }
        public virtual DbSet<BaseFilefolder> BaseFilefolder { get; set; }
        public virtual DbSet<BaseFileinfo> BaseFileinfo { get; set; }
        public virtual DbSet<BaseFileinfoVersion> BaseFileinfoVersion { get; set; }
        public virtual DbSet<BaseFilterip> BaseFilterip { get; set; }
        public virtual DbSet<BaseFiltertime> BaseFiltertime { get; set; }
        public virtual DbSet<BaseIssue> BaseIssue { get; set; }
        public virtual DbSet<BaseIssuenewrelation> BaseIssuenewrelation { get; set; }
        public virtual DbSet<BaseIssueTalk> BaseIssueTalk { get; set; }
        public virtual DbSet<BaseIssueUser> BaseIssueUser { get; set; }
        public virtual DbSet<BaseLog> BaseLog { get; set; }
        public virtual DbSet<BaseLogext> BaseLogext { get; set; }
        public virtual DbSet<BaseMaterial> BaseMaterial { get; set; }
        public virtual DbSet<BaseMaterialelements> BaseMaterialelements { get; set; }
        public virtual DbSet<BaseMaterialrecord> BaseMaterialrecord { get; set; }
        public virtual DbSet<BaseMessagequeue> BaseMessagequeue { get; set; }
        public virtual DbSet<BaseModule> BaseModule { get; set; }
        public virtual DbSet<BaseModulebutton> BaseModulebutton { get; set; }
        public virtual DbSet<BaseModulecolumn> BaseModulecolumn { get; set; }
        public virtual DbSet<BaseModuleform> BaseModuleform { get; set; }
        public virtual DbSet<BaseModuleforminstance> BaseModuleforminstance { get; set; }
        public virtual DbSet<BaseNewlog> BaseNewlog { get; set; }
        public virtual DbSet<BaseNews> BaseNews { get; set; }
        public virtual DbSet<BaseOrganize> BaseOrganize { get; set; }
        public virtual DbSet<BaseOrganizedetail> BaseOrganizedetail { get; set; }
        public virtual DbSet<BaseOrganizeextend> BaseOrganizeextend { get; set; }
        public virtual DbSet<BaseOrganizegis> BaseOrganizegis { get; set; }
        public virtual DbSet<BaseOrganizeplus> BaseOrganizeplus { get; set; }
        public virtual DbSet<BaseOrgimg> BaseOrgimg { get; set; }
        public virtual DbSet<BaseProjectnews> BaseProjectnews { get; set; }
        public virtual DbSet<BaseProjectscore> BaseProjectscore { get; set; }
        public virtual DbSet<BaseProjecttemplate> BaseProjecttemplate { get; set; }
        public virtual DbSet<BasePublicextend> BasePublicextend { get; set; }
        public virtual DbSet<BaseRelation> BaseRelation { get; set; }
        public virtual DbSet<BaseRole> BaseRole { get; set; }
        public virtual DbSet<BaseSchedule> BaseSchedule { get; set; }
        public virtual DbSet<BaseScheduleAttachment> BaseScheduleAttachment { get; set; }
        public virtual DbSet<BaseScheduleParticipant> BaseScheduleParticipant { get; set; }
        public virtual DbSet<BaseSpecialpw> BaseSpecialpw { get; set; }
        public virtual DbSet<BaseTemplateFolder> BaseTemplateFolder { get; set; }
        public virtual DbSet<BaseUser> BaseUser { get; set; }
        public virtual DbSet<BaseUserext> BaseUserext { get; set; }
        public virtual DbSet<BaseUserrelation> BaseUserrelation { get; set; }
        public virtual DbSet<BaseUsertag> BaseUsertag { get; set; }
        public virtual DbSet<BimcompAttach> BimcompAttach { get; set; }
        public virtual DbSet<BimcompCategory> BimcompCategory { get; set; }
        public virtual DbSet<BimcompFamily> BimcompFamily { get; set; }
        public virtual DbSet<BimcompFaprop> BimcompFaprop { get; set; }
        public virtual DbSet<BimcompFapropcategory> BimcompFapropcategory { get; set; }
        public virtual DbSet<BimcompFile> BimcompFile { get; set; }
        public virtual DbSet<BimcompRelmodel> BimcompRelmodel { get; set; }
        public virtual DbSet<BimcompReltag> BimcompReltag { get; set; }
        public virtual DbSet<BimcompTag> BimcompTag { get; set; }
        public virtual DbSet<CfgUrls> CfgUrls { get; set; }
        public virtual DbSet<ClientCashbalance> ClientCashbalance { get; set; }
        public virtual DbSet<ClientChance> ClientChance { get; set; }
        public virtual DbSet<ClientCustomer> ClientCustomer { get; set; }
        public virtual DbSet<ClientCustomercontact> ClientCustomercontact { get; set; }
        public virtual DbSet<ClientExpenses> ClientExpenses { get; set; }
        public virtual DbSet<ClientInvoice> ClientInvoice { get; set; }
        public virtual DbSet<ClientOrder> ClientOrder { get; set; }
        public virtual DbSet<ClientOrderentry> ClientOrderentry { get; set; }
        public virtual DbSet<ClientReceivable> ClientReceivable { get; set; }
        public virtual DbSet<ClientTrailrecord> ClientTrailrecord { get; set; }
        public virtual DbSet<ComPdfCache> ComPdfCache { get; set; }
        public virtual DbSet<EmailAddressee> EmailAddressee { get; set; }
        public virtual DbSet<EmailCategory> EmailCategory { get; set; }
        public virtual DbSet<EmailContent> EmailContent { get; set; }
        public virtual DbSet<Errno> Errno { get; set; }
        public virtual DbSet<ExamCategory> ExamCategory { get; set; }
        public virtual DbSet<ImContent> ImContent { get; set; }
        public virtual DbSet<ImGroup> ImGroup { get; set; }
        public virtual DbSet<ImRead> ImRead { get; set; }
        public virtual DbSet<ImUsergroup> ImUsergroup { get; set; }
        public virtual DbSet<IssueStatus> IssueStatus { get; set; }
        public virtual DbSet<IssueTag> IssueTag { get; set; }
        public virtual DbSet<IssueType> IssueType { get; set; }
        public virtual DbSet<MsgMsg> MsgMsg { get; set; }
        public virtual DbSet<MsgMsgext> MsgMsgext { get; set; }
        public virtual DbSet<MsgUser> MsgUser { get; set; }
        public virtual DbSet<MtrOuterpage> MtrOuterpage { get; set; }
        public virtual DbSet<OperLog> OperLog { get; set; }
        public virtual DbSet<OrgUserorganize> OrgUserorganize { get; set; }
        public virtual DbSet<PanoramaBase> PanoramaBase { get; set; }
        public virtual DbSet<PanoramaPointinfo> PanoramaPointinfo { get; set; }
        public virtual DbSet<PlusProject> PlusProject { get; set; }
        public virtual DbSet<PlusrelTaskelements> PlusrelTaskelements { get; set; }
        public virtual DbSet<PlusResource> PlusResource { get; set; }
        public virtual DbSet<PlusTask3> PlusTask3 { get; set; }
        public virtual DbSet<RelIssueIssueuser> RelIssueIssueuser { get; set; }
        public virtual DbSet<RelIssueTag> RelIssueTag { get; set; }
        public virtual DbSet<RptTemp> RptTemp { get; set; }
        public virtual DbSet<SharedModel> SharedModel { get; set; }
        public virtual DbSet<SyncMaterialarrange> SyncMaterialarrange { get; set; }
        public virtual DbSet<WechatApp> WechatApp { get; set; }
        public virtual DbSet<WechatDeptrelation> WechatDeptrelation { get; set; }
        public virtual DbSet<WechatUserrelation> WechatUserrelation { get; set; }
        public virtual DbSet<WfDelegaterecord> WfDelegaterecord { get; set; }
        public virtual DbSet<WfDelegaterule> WfDelegaterule { get; set; }
        public virtual DbSet<WfDelegateruleschemeinfo> WfDelegateruleschemeinfo { get; set; }
        public virtual DbSet<WfFieldcfg> WfFieldcfg { get; set; }
        public virtual DbSet<WfFlowinstance> WfFlowinstance { get; set; }
        public virtual DbSet<WfFlowinstanceactive> WfFlowinstanceactive { get; set; }
        public virtual DbSet<WfFlowrecord> WfFlowrecord { get; set; }
        public virtual DbSet<WfFrmmain> WfFrmmain { get; set; }
        public virtual DbSet<WfLinebtns> WfLinebtns { get; set; }
        public virtual DbSet<WfNodedatas> WfNodedatas { get; set; }
        public virtual DbSet<WfProcessinstance> WfProcessinstance { get; set; }
        public virtual DbSet<WfProcessoperationhistory> WfProcessoperationhistory { get; set; }
        public virtual DbSet<WfProcessscheme> WfProcessscheme { get; set; }
        public virtual DbSet<WfProcesstransitionhistory> WfProcesstransitionhistory { get; set; }
        public virtual DbSet<WfProjectschemerelation> WfProjectschemerelation { get; set; }
        public virtual DbSet<WfSchemecontent> WfSchemecontent { get; set; }
        public virtual DbSet<WfSchemeinfo> WfSchemeinfo { get; set; }
        public virtual DbSet<WfSchemeinfoauthorize> WfSchemeinfoauthorize { get; set; }

        // Unable to generate entity type for table 'api_examinerectification'. Please see the warning messages.
        // Unable to generate entity type for table 'base_module_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'base_organizeextendbak'. Please see the warning messages.
        // Unable to generate entity type for table 'base_projectnews_copy'. Please see the warning messages.
        // Unable to generate entity type for table 'base_user_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'del_plustask1'. Please see the warning messages.
        // Unable to generate entity type for table 'del_plustask2'. Please see the warning messages.
        // Unable to generate entity type for table 'ipwhite'. Please see the warning messages.
        // Unable to generate entity type for table 'plus_task'. Please see the warning messages.
        // Unable to generate entity type for table 'plus_task_originbak'. Please see the warning messages.
        // Unable to generate entity type for table 'share_doc'. Please see the warning messages.
        // Unable to generate entity type for table 'sysloginlog'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=www.probim.cn;uid=root;pwd=baye621505.;port=3306;database=probim;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.AccountId).HasColumnType("varchar(50)");

                entity.Property(e => e.AmountCount).HasColumnType("int(11)");

                entity.Property(e => e.CompanyName).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ExpireTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IpaddressName)
                    .HasColumnName("IPAddressName")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.IsResetPwd)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LastVisit).HasColumnType("datetime");

                entity.Property(e => e.LogOnCount).HasColumnType("int(11)");

                entity.Property(e => e.MobileCode).HasColumnType("varchar(11)");

                entity.Property(e => e.Password).HasColumnType("varchar(50)");

                entity.Property(e => e.RegisterTime).HasColumnType("datetime");

                entity.Property(e => e.SecurityCode).HasColumnType("varchar(6)");
            });

            modelBuilder.Entity<Api2Invite>(entity =>
            {
                entity.HasKey(e => e.InvGuid);

                entity.ToTable("api2_invite");

                entity.Property(e => e.InvGuid)
                    .HasColumnName("inv_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InvCreatedate)
                    .HasColumnName("inv_createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvDeadlinedate)
                    .HasColumnName("inv_deadlinedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvEmail)
                    .HasColumnName("inv_email")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InvInvitecode)
                    .HasColumnName("inv_invitecode")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InvRoleId)
                    .HasColumnName("inv_roleId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Api2Recycles>(entity =>
            {
                entity.HasKey(e => e.ArccGuid);

                entity.ToTable("api2_recycles");

                entity.Property(e => e.ArccGuid)
                    .HasColumnName("arcc_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArccIfdirname)
                    .HasColumnName("arcc_ifdirname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArccModifytime)
                    .HasColumnName("arcc_modifytime")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArccObjectId)
                    .HasColumnName("arcc_objectId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArccOrganizeId)
                    .HasColumnName("arcc_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArccType)
                    .HasColumnName("arcc_type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Api2Session>(entity =>
            {
                entity.HasKey(e => e.ApisessionId);

                entity.ToTable("api2_session");

                entity.Property(e => e.ApisessionId)
                    .HasColumnName("apisession_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ApisessionCompanyid)
                    .HasColumnName("apisession_companyid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ApisessionCurrenttime)
                    .HasColumnName("apisession_currenttime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApisessionToken)
                    .HasColumnName("apisession_token")
                    .HasColumnType("text");

                entity.Property(e => e.ApisessionUserid)
                    .HasColumnName("apisession_userid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Api2Suscribe>(entity =>
            {
                entity.HasKey(e => e.AsusGuid);

                entity.ToTable("api2_suscribe");

                entity.Property(e => e.AsusGuid)
                    .HasColumnName("asus_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AsusIfdirname)
                    .HasColumnName("asus_ifdirname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AsusIfdirupdtime)
                    .HasColumnName("asus_ifdirupdtime")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AsusObjectId)
                    .HasColumnName("asus_objectId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AsusOrganizeId)
                    .HasColumnName("asus_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AsusType)
                    .HasColumnName("asus_type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AsusUserId)
                    .HasColumnName("asus_userId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Api2Validcode>(entity =>
            {
                entity.HasKey(e => e.AvcGuid);

                entity.ToTable("api2_validcode");

                entity.Property(e => e.AvcGuid)
                    .HasColumnName("avc_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AvcCode)
                    .HasColumnName("avc_code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AvcHadvalided)
                    .HasColumnName("avc_hadvalided")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvcSessionId)
                    .HasColumnName("avc_sessionId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ApiDrawposinfo>(entity =>
            {
                entity.HasKey(e => e.Gid);

                entity.ToTable("api_drawposinfo");

                entity.Property(e => e.Gid)
                    .HasColumnName("GID")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExamineId).HasColumnType("varchar(50)");

                entity.Property(e => e.FileId).HasColumnType("varchar(50)");

                entity.Property(e => e.Height).HasColumnType("varchar(50)");

                entity.Property(e => e.IsDel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OpId).HasColumnType("varchar(50)");

                entity.Property(e => e.OpUser).HasColumnType("varchar(50)");

                entity.Property(e => e.Pixel2Mx)
                    .HasColumnName("Pixel2MX")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Pixel2My)
                    .HasColumnName("Pixel2MY")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PosX).HasColumnType("int(11)");

                entity.Property(e => e.PosY).HasColumnType("int(11)");

                entity.Property(e => e.Width).HasColumnType("varchar(50)");

                entity.Property(e => e.X).HasColumnType("varchar(50)");

                entity.Property(e => e.Y).HasColumnType("varchar(50)");

                entity.Property(e => e.Z).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ApiExamineattachment>(entity =>
            {
                entity.HasKey(e => e.ExamineAttachmentId);

                entity.ToTable("api_examineattachment");

                entity.Property(e => e.ExamineAttachmentId)
                    .HasColumnName("ExamineAttachmentID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AttachmentName).HasColumnType("varchar(50)");

                entity.Property(e => e.AttachmentType).HasColumnType("varchar(50)");

                entity.Property(e => e.AttachmentUrl).HasColumnType("longtext");

                entity.Property(e => e.CheckFlag)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ExamineId)
                    .HasColumnName("ExamineID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IsDel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApiExaminedata>(entity =>
            {
                entity.HasKey(e => e.ExamineId);

                entity.ToTable("api_examinedata");

                entity.Property(e => e.ExamineId)
                    .HasColumnName("ExamineID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Axis).HasColumnType("varchar(100)");

                entity.Property(e => e.AxisId)
                    .HasColumnName("AxisID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Category).HasColumnType("varchar(50)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ConstructUnit).HasColumnType("varchar(100)");

                entity.Property(e => e.ConstructUnitId)
                    .HasColumnName("ConstructUnitID")
                    .HasColumnType("varchar(1100)");

                entity.Property(e => e.ConstructionTeam).HasColumnType("varchar(100)");

                entity.Property(e => e.ConstructionTeamId)
                    .HasColumnName("ConstructionTeamID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExamineDate).HasColumnType("datetime");

                entity.Property(e => e.ExamineRemark).HasColumnType("varchar(1024)");

                entity.Property(e => e.ExamineResult).HasColumnType("varchar(50)");

                entity.Property(e => e.Examiner).HasColumnType("varchar(1024)");

                entity.Property(e => e.ExaminerId)
                    .HasColumnName("ExaminerID")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.FirstCheckDate).HasColumnType("datetime");

                entity.Property(e => e.FirstCheckRemark).HasColumnType("varchar(2048)");

                entity.Property(e => e.FirstCheckResult).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstCheckerId)
                    .HasColumnName("FirstCheckerID")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.FirstCheckerName).HasColumnType("varchar(1024)");

                entity.Property(e => e.FloorId)
                    .HasColumnName("FloorID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FloorName).HasColumnType("varchar(50)");

                entity.Property(e => e.FlowPhase).HasColumnType("varchar(50)");

                entity.Property(e => e.FlowPhaseId)
                    .HasColumnName("FlowPhaseID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.IsDel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LinkId)
                    .HasColumnName("LinkID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LinkType).HasColumnType("varchar(50)");

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Placement).HasColumnType("varchar(50)");

                entity.Property(e => e.Principal).HasColumnType("varchar(1024)");

                entity.Property(e => e.PrincipalId)
                    .HasColumnName("PrincipalID")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Professional).HasColumnType("varchar(50)");

                entity.Property(e => e.ProfessionalId)
                    .HasColumnName("ProfessionalID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RectificateDate).HasColumnType("datetime");

                entity.Property(e => e.RelationMember).HasColumnType("varchar(1024)");

                entity.Property(e => e.RelationMemberId)
                    .HasColumnName("RelationMemberID")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.SecondCheckDate).HasColumnType("datetime");

                entity.Property(e => e.SecondCheckRemark).HasColumnType("varchar(2048)");

                entity.Property(e => e.SecondCheckResult).HasColumnType("varchar(1024)");

                entity.Property(e => e.SecondCheckerId)
                    .HasColumnName("SecondCheckerID")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.SecondCheckerName).HasColumnType("varchar(1024)");

                entity.Property(e => e.SubConstructUnit).HasColumnType("varchar(100)");

                entity.Property(e => e.SubConstructUnitId)
                    .HasColumnName("SubConstructUnitID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Subdivisional).HasColumnType("varchar(100)");

                entity.Property(e => e.SubdivisionalId)
                    .HasColumnName("SubdivisionalID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Title).HasColumnType("longtext");

                entity.Property(e => e.VerifyBatch).HasColumnType("varchar(100)");

                entity.Property(e => e.VerifyBatchId)
                    .HasColumnName("VerifyBatchID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ViewId)
                    .HasColumnName("ViewID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ViewpointId)
                    .HasColumnName("ViewpointID")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ApiExaminedataextend>(entity =>
            {
                entity.HasKey(e => e.AedeGuid);

                entity.ToTable("api_examinedataextend");

                entity.Property(e => e.AedeGuid)
                    .HasColumnName("aede_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AedeCheckeruserids)
                    .HasColumnName("aede_checkeruserids")
                    .HasColumnType("longtext");

                entity.Property(e => e.AedeExamineId)
                    .HasColumnName("aede_examineID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AedeExaminetype)
                    .HasColumnName("aede_examinetype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AedeSeveritylevel)
                    .HasColumnName("aede_severitylevel")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ApiExaminedatatype>(entity =>
            {
                entity.HasKey(e => e.AedtGuid);

                entity.ToTable("api_examinedatatype");

                entity.Property(e => e.AedtGuid)
                    .HasColumnName("aedt_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AedtName)
                    .HasColumnName("aedt_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AedtOrganizeId)
                    .HasColumnName("aedt_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AedtType)
                    .HasColumnName("aedt_type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<AuthRolephase>(entity =>
            {
                entity.HasKey(e => e.ArpGuid);

                entity.ToTable("auth_rolephase");

                entity.Property(e => e.ArpGuid)
                    .HasColumnName("arp_Guid")
                    .HasColumnType("char(50)");

                entity.Property(e => e.ArpBimcomposerId)
                    .HasColumnName("arp_BIMComposerID")
                    .HasColumnType("char(50)");

                entity.Property(e => e.ArpEnable)
                    .HasColumnName("arp_Enable")
                    .HasColumnType("char(50)");

                entity.Property(e => e.ArpPhase)
                    .HasColumnName("arp_Phase")
                    .HasColumnType("char(50)");

                entity.Property(e => e.ArpProjectId)
                    .HasColumnName("arp_ProjectID")
                    .HasColumnType("char(50)");

                entity.Property(e => e.ArpRoleId)
                    .HasColumnName("arp_RoleId")
                    .HasColumnType("char(50)");
            });

            modelBuilder.Entity<BaseArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("base_area");

                entity.Property(e => e.AreaId).HasColumnType("varchar(50)");

                entity.Property(e => e.AreaCode).HasColumnType("varchar(50)");

                entity.Property(e => e.AreaName).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.Layer).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.QuickQuery).HasColumnType("varchar(200)");

                entity.Property(e => e.SimpleSpelling).HasColumnType("varchar(200)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseAuthorize>(entity =>
            {
                entity.HasKey(e => e.AuthorizeId);

                entity.ToTable("base_authorize");

                entity.Property(e => e.AuthorizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(50)");

                entity.Property(e => e.ItemType).HasColumnType("int(11)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseAuthorizedata>(entity =>
            {
                entity.HasKey(e => e.AuthorizeDataId);

                entity.ToTable("base_authorizedata");

                entity.Property(e => e.AuthorizeDataId).HasColumnType("varchar(50)");

                entity.Property(e => e.AuthorizeConstraint).HasColumnType("varchar(200)");

                entity.Property(e => e.AuthorizeType).HasColumnType("int(11)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.IsRead).HasColumnType("int(11)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(50)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.ResourceId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseCategory>(entity =>
            {
                entity.HasKey(e => e.BcGuid);

                entity.ToTable("base_category");

                entity.Property(e => e.BcGuid)
                    .HasColumnName("bc_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcCategoryname)
                    .HasColumnName("bc_categoryname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcCategorytype)
                    .HasColumnName("bc_categorytype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcCreatetime)
                    .HasColumnName("bc_createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BcExtjson)
                    .HasColumnName("bc_extjson")
                    .HasColumnType("longtext");

                entity.Property(e => e.BcOrganizeId)
                    .HasColumnName("bc_organizeId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseCoderule>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.ToTable("base_coderule");

                entity.Property(e => e.RuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.CurrentNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.Mode).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Module).HasColumnType("varchar(50)");

                entity.Property(e => e.ModuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.RuleFormatJson).HasColumnType("longtext");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseCoderuleseed>(entity =>
            {
                entity.HasKey(e => e.RuleSeedId);

                entity.ToTable("base_coderuleseed");

                entity.Property(e => e.RuleSeedId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.RuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.SeedValue).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseCompanydata>(entity =>
            {
                entity.HasKey(e => e.CompanydataId);

                entity.ToTable("base_companydata");

                entity.Property(e => e.CompanydataId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("varchar(30)");

                entity.Property(e => e.JsonData).HasColumnType("varchar(20000)");

                entity.Property(e => e.ModifyDate).HasColumnType("varchar(30)");

                entity.Property(e => e.OrganizeId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseDatabasebackup>(entity =>
            {
                entity.HasKey(e => e.DatabaseBackupId);

                entity.ToTable("base_databasebackup");

                entity.Property(e => e.DatabaseBackupId).HasColumnType("varchar(50)");

                entity.Property(e => e.BackupPath).HasColumnType("varchar(200)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DatabaseLinkId).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ExecuteMode).HasColumnType("int(11)");

                entity.Property(e => e.ExecuteTime).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseDatabaselink>(entity =>
            {
                entity.HasKey(e => e.DatabaseLinkId);

                entity.ToTable("base_databaselink");

                entity.Property(e => e.DatabaseLinkId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DbConnection).HasColumnType("varchar(200)");

                entity.Property(e => e.DbType).HasColumnType("varchar(50)");

                entity.Property(e => e.Dbalias)
                    .HasColumnName("DBAlias")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Dbname)
                    .HasColumnName("DBName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.Desencrypt)
                    .HasColumnName("DESEncrypt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ServerAddress).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.Version).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseDataitem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("base_dataitem");

                entity.Property(e => e.ItemId).HasColumnType("varchar(50)");

                entity.Property(e => e.Category).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FlagId)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsNav).HasColumnType("int(11)");

                entity.Property(e => e.IsTree).HasColumnType("int(11)");

                entity.Property(e => e.ItemCode).HasColumnType("varchar(50)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseDataitemdetail>(entity =>
            {
                entity.HasKey(e => e.ItemDetailId);

                entity.ToTable("base_dataitemdetail");

                entity.Property(e => e.ItemDetailId).HasColumnType("varchar(50)");

                entity.Property(e => e.Category)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FlagId)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsDefault).HasColumnType("int(11)");

                entity.Property(e => e.ItemCode).HasColumnType("varchar(50)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(50)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(50)");

                entity.Property(e => e.ItemValue).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.QuickQuery).HasColumnType("varchar(200)");

                entity.Property(e => e.SimpleSpelling).HasColumnType("varchar(200)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("base_department");

                entity.Property(e => e.DepartmentId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.InnerPhone).HasColumnType("varchar(50)");

                entity.Property(e => e.Layer).HasColumnType("int(11)");

                entity.Property(e => e.Manager).HasColumnType("varchar(50)");

                entity.Property(e => e.ManagerId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Nature).HasColumnType("varchar(50)");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.OuterPhone).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.ShortName).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseFile>(entity =>
            {
                entity.HasKey(e => e.BfGuid);

                entity.ToTable("base_file");

                entity.Property(e => e.BfGuid)
                    .HasColumnName("bf_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BfFilename)
                    .HasColumnName("bf_filename")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BfMd5)
                    .HasColumnName("bf_md5")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BfPath)
                    .HasColumnName("bf_path")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<BaseFilefolder>(entity =>
            {
                entity.HasKey(e => e.FolderId);

                entity.ToTable("base_filefolder");

                entity.Property(e => e.FolderId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FolderName).HasColumnType("varchar(200)");

                entity.Property(e => e.FolderType).HasColumnType("varchar(50)");

                entity.Property(e => e.IsShare).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.ShareCode).HasColumnType("int(11)");

                entity.Property(e => e.ShareLink).HasColumnType("varchar(200)");

                entity.Property(e => e.ShareTime).HasColumnType("datetime");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseFileinfo>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("base_fileinfo");

                entity.Property(e => e.FileId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.DownloadCount).HasColumnType("int(11)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FileExtensions).HasColumnType("varchar(50)");

                entity.Property(e => e.FileName).HasColumnType("varchar(200)");

                entity.Property(e => e.FilePath).HasColumnType("varchar(200)");

                entity.Property(e => e.FileSize).HasColumnType("varchar(50)");

                entity.Property(e => e.FileType).HasColumnType("varchar(50)");

                entity.Property(e => e.FolderId).HasColumnType("varchar(50)");

                entity.Property(e => e.IsShare).HasColumnType("int(11)");

                entity.Property(e => e.IsTop).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ShareCode).HasColumnType("int(11)");

                entity.Property(e => e.ShareLink).HasColumnType("varchar(200)");

                entity.Property(e => e.ShareTime).HasColumnType("datetime");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseFileinfoVersion>(entity =>
            {
                entity.HasKey(e => e.FileInfoVersionId);

                entity.ToTable("base_fileinfo_version");

                entity.Property(e => e.FileInfoVersionId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnName("CreateUserID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.FileId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FileSize)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FileVersion).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseFilterip>(entity =>
            {
                entity.HasKey(e => e.FilterIpid);

                entity.ToTable("base_filterip");

                entity.Property(e => e.FilterIpid)
                    .HasColumnName("FilterIPId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.Iplimit)
                    .HasColumnName("IPLimit")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectType).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.VisitType).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseFiltertime>(entity =>
            {
                entity.HasKey(e => e.FilterTimeId);

                entity.ToTable("base_filtertime");

                entity.Property(e => e.FilterTimeId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectType).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.VisitType).HasColumnType("int(11)");

                entity.Property(e => e.WeekDay1).HasColumnType("varchar(200)");

                entity.Property(e => e.WeekDay2).HasColumnType("varchar(200)");

                entity.Property(e => e.WeekDay3).HasColumnType("varchar(200)");

                entity.Property(e => e.WeekDay4).HasColumnType("varchar(200)");

                entity.Property(e => e.WeekDay5).HasColumnType("varchar(200)");

                entity.Property(e => e.WeekDay6).HasColumnType("varchar(200)");

                entity.Property(e => e.WeekDay7).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<BaseIssue>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("base_issue");

                entity.Property(e => e.IssueId).HasColumnType("varchar(50)");

                entity.Property(e => e.Content).HasColumnType("varchar(5000)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl).HasColumnType("longtext");

                entity.Property(e => e.IsPublic)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IssueStatus)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IssueTypeId)
                    .HasColumnName("IssueTypeID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModelId).HasColumnType("varchar(50)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ViewpointId)
                    .HasColumnName("ViewpointID")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<BaseIssuenewrelation>(entity =>
            {
                entity.HasKey(e => e.BinrId);

                entity.ToTable("base_issuenewrelation");

                entity.Property(e => e.BinrId)
                    .HasColumnName("BINR_ID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BinrImage2DModelId)
                    .HasColumnName("BINR_Image2D_ModelID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BinrImage2DPosition)
                    .HasColumnName("BINR_Image2D_Position")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BinrImage2Did)
                    .HasColumnName("BINR_Image2DID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BinrIssueId)
                    .HasColumnName("BINR_IssueID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BinrViewPointId)
                    .HasColumnName("BINR_ViewPointID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BinrViewPointModelId)
                    .HasColumnName("BINR_ViewPoint_ModelID")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseIssueTalk>(entity =>
            {
                entity.HasKey(e => e.IssueTalkId);

                entity.ToTable("base_issue_talk");

                entity.Property(e => e.IssueTalkId)
                    .HasColumnName("Issue_TalkId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CommentPatchGuid)
                    .HasColumnName("CommentPatchGUID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Content).HasColumnType("varchar(5000)");

                entity.Property(e => e.ContentType).HasColumnType("varchar(255)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.IssueId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IssuePtalkId)
                    .HasColumnName("Issue_PTalkId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserOfUnRead).HasColumnType("varchar(10000)");
            });

            modelBuilder.Entity<BaseIssueUser>(entity =>
            {
                entity.HasKey(e => e.IssueUserId);

                entity.ToTable("base_issue_user");

                entity.Property(e => e.IssueUserId)
                    .HasColumnName("Issue_User_Id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IsRead).HasColumnType("int(11)");

                entity.Property(e => e.IssueId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Iutype)
                    .IsRequired()
                    .HasColumnName("IUType")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("base_log");

                entity.Property(e => e.LogId).HasColumnType("varchar(50)");

                entity.Property(e => e.Browser).HasColumnType("varchar(50)");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ExecuteResult).HasColumnType("int(11)");

                entity.Property(e => e.ExecuteResultJson).HasColumnType("longtext");

                entity.Property(e => e.Host).HasColumnType("varchar(200)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IpaddressName)
                    .HasColumnName("IPAddressName")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Module).HasColumnType("varchar(200)");

                entity.Property(e => e.ModuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.OperateAccount).HasColumnType("varchar(50)");

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateType).HasColumnType("varchar(50)");

                entity.Property(e => e.OperateTypeId).HasColumnType("varchar(50)");

                entity.Property(e => e.OperateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.SourceContentJson).HasColumnType("longtext");

                entity.Property(e => e.SourceObjectId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseLogext>(entity =>
            {
                entity.HasKey(e => e.BleGuid);

                entity.ToTable("base_logext");

                entity.Property(e => e.BleGuid)
                    .HasColumnName("ble_guid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.BlGuid)
                    .HasColumnName("bl_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BleActionname)
                    .HasColumnName("ble_actionname")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.BleIssueId)
                    .HasColumnName("ble_issueId")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.BleObjecttype)
                    .HasColumnName("ble_objecttype")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.BleOrganize1Id)
                    .HasColumnName("ble_organize1Id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.BleOrganize2Id)
                    .HasColumnName("ble_organize2Id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.BleRoleId)
                    .HasColumnName("ble_roleId")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.BleUserId)
                    .HasColumnName("ble_userId")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<BaseMaterial>(entity =>
            {
                entity.HasKey(e => e.BmGuid);

                entity.ToTable("base_material");

                entity.Property(e => e.BmGuid)
                    .HasColumnName("bm_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcGuidMaterialstatus)
                    .HasColumnName("bc_guid_materialstatus")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcGuidMaterialtype)
                    .HasColumnName("bc_guid_materialtype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmExtjson)
                    .HasColumnName("bm_extjson")
                    .HasColumnType("longtext");

                entity.Property(e => e.BmMaterialcode)
                    .HasColumnName("bm_materialcode")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmMaterialcount).HasColumnName("bm_materialcount");

                entity.Property(e => e.BmMaterialfac)
                    .HasColumnName("bm_materialfac")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmMaterialmodel)
                    .HasColumnName("bm_materialmodel")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmMaterialname)
                    .HasColumnName("bm_materialname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmMaterialunit)
                    .HasColumnName("bm_materialunit")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmPlanarrtime)
                    .HasColumnName("bm_planarrtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BmUpdatetime)
                    .HasColumnName("bm_updatetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BaseMaterialelements>(entity =>
            {
                entity.HasKey(e => e.BmeGuid);

                entity.ToTable("base_materialelements");

                entity.Property(e => e.BmeGuid)
                    .HasColumnName("bme_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmeCreatetime)
                    .HasColumnName("bme_createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BmeElementids)
                    .HasColumnName("bme_elementids")
                    .HasColumnType("longtext");

                entity.Property(e => e.BmeMaterialid)
                    .HasColumnName("bme_materialid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmeUpdatetime)
                    .HasColumnName("bme_updatetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BaseMaterialrecord>(entity =>
            {
                entity.HasKey(e => e.BmrGuid);

                entity.ToTable("base_materialrecord");

                entity.Property(e => e.BmrGuid)
                    .HasColumnName("bmr_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmGuid)
                    .HasColumnName("bm_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmrOperDescription)
                    .HasColumnName("bmr_operDescription")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmrOperItems)
                    .HasColumnName("bmr_operItems")
                    .HasColumnType("longtext");

                entity.Property(e => e.BmrOperdate)
                    .HasColumnName("bmr_operdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BmrUserId)
                    .HasColumnName("bmr_userId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BmrUserName)
                    .HasColumnName("bmr_userName")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseMessagequeue>(entity =>
            {
                entity.HasKey(e => e.MessageQueueId);

                entity.ToTable("base_messagequeue");

                entity.Property(e => e.MessageQueueId).HasColumnType("varchar(50)");

                entity.Property(e => e.Category).HasColumnType("int(10)");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.IsDel)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.IsPushed)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.MessageContent).HasColumnType("varchar(2048)");

                entity.Property(e => e.ReceiverContact).HasColumnType("varchar(2048)");
            });

            modelBuilder.Entity<BaseModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("base_module");

                entity.Property(e => e.ModuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.AllowDelete).HasColumnType("int(11)");

                entity.Property(e => e.AllowEdit).HasColumnType("int(11)");

                entity.Property(e => e.AllowExpand).HasColumnType("int(11)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FullName).HasColumnType("varchar(200)");

                entity.Property(e => e.Icon).HasColumnType("varchar(50)");

                entity.Property(e => e.IsMenu).HasColumnType("int(11)");

                entity.Property(e => e.IsPublic).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.Target).HasColumnType("varchar(20)");

                entity.Property(e => e.UrlAddress).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<BaseModulebutton>(entity =>
            {
                entity.HasKey(e => e.ModuleButtonId);

                entity.ToTable("base_modulebutton");

                entity.Property(e => e.ModuleButtonId).HasColumnType("varchar(50)");

                entity.Property(e => e.ActionAddress).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.Icon).HasColumnType("varchar(50)");

                entity.Property(e => e.ModuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseModulecolumn>(entity =>
            {
                entity.HasKey(e => e.ModuleColumnId);

                entity.ToTable("base_modulecolumn");

                entity.Property(e => e.ModuleColumnId).HasColumnType("varchar(50)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.ModuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseModuleform>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("base_moduleform");

                entity.Property(e => e.FormId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FormJson).HasColumnType("varchar(2048)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ModuleId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseModuleforminstance>(entity =>
            {
                entity.HasKey(e => e.FormInstanceId);

                entity.ToTable("base_moduleforminstance");

                entity.Property(e => e.FormInstanceId).HasColumnType("varchar(50)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.FormId).HasColumnType("varchar(50)");

                entity.Property(e => e.FormInstanceJson).HasColumnType("varchar(2048)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseNewlog>(entity =>
            {
                entity.HasKey(e => e.BnlGuid);

                entity.ToTable("base_newlog");

                entity.Property(e => e.BnlGuid)
                    .HasColumnName("bnl_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BnlDatetime)
                    .HasColumnName("bnl_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BnlDesc)
                    .HasColumnName("bnl_desc")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.BnlModule)
                    .HasColumnName("bnl_module")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BnlOriginOrganizeId)
                    .HasColumnName("bnl_originOrganizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BnlOriginUserId)
                    .HasColumnName("bnl_originUserId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BnlType)
                    .HasColumnName("bnl_type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseNews>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("base_news");

                entity.Property(e => e.NewsId).HasColumnType("varchar(50)");

                entity.Property(e => e.AuthorName).HasColumnType("varchar(50)");

                entity.Property(e => e.BriefHead).HasColumnType("varchar(50)");

                entity.Property(e => e.Category).HasColumnType("varchar(50)");

                entity.Property(e => e.CompileName).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FullHead).HasColumnType("varchar(200)");

                entity.Property(e => e.FullHeadColor).HasColumnType("varchar(50)");

                entity.Property(e => e.Keyword).HasColumnType("varchar(200)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.NewsContent).HasColumnType("longtext");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.Pv)
                    .HasColumnName("PV")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReleaseTime).HasColumnType("datetime");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.SourceAddress).HasColumnType("varchar(50)");

                entity.Property(e => e.SourceName).HasColumnType("varchar(50)");

                entity.Property(e => e.TagWord).HasColumnType("varchar(200)");

                entity.Property(e => e.TypeId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseOrganize>(entity =>
            {
                entity.HasKey(e => e.OrganizeId);

                entity.ToTable("base_organize");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.Address).HasColumnType("varchar(50)");

                entity.Property(e => e.BusinessScope).HasColumnType("varchar(200)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.CertificateCode)
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CityId).HasColumnType("varchar(50)");

                entity.Property(e => e.CountyId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DataFrom)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(2048)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ExistsActivityTotal)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExistsArchiveTotal)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.FoundedTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasColumnType("varchar(1024)");

                entity.Property(e => e.InnerPhone).HasColumnType("varchar(50)");

                entity.Property(e => e.IsSample)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Layer).HasColumnType("int(11)");

                entity.Property(e => e.MachineCode)
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Manager).HasColumnType("varchar(50)");

                entity.Property(e => e.ManagerId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Nature).HasColumnType("varchar(50)");

                entity.Property(e => e.OuterPhone).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Postalcode).HasColumnType("varchar(50)");

                entity.Property(e => e.ProvinceId).HasColumnType("varchar(50)");

                entity.Property(e => e.ShortName).HasColumnType("varchar(1024)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.WebAddress).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<BaseOrganizedetail>(entity =>
            {
                entity.HasKey(e => e.BodGuid);

                entity.ToTable("base_organizedetail");

                entity.Property(e => e.BodGuid)
                    .HasColumnName("bod_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BodOrganizeId)
                    .HasColumnName("bod_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BodWillshowname)
                    .HasColumnName("bod_willshowname")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BaseOrganizeextend>(entity =>
            {
                entity.HasKey(e => e.OrganizeExtendId);

                entity.ToTable("base_organizeextend");

                entity.Property(e => e.OrganizeExtendId).HasColumnType("varchar(50)");

                entity.Property(e => e.BimcomposerId)
                    .HasColumnName("BIMComposerID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ConstructionUnit)
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description).HasColumnType("varchar(2048)");

                entity.Property(e => e.DesignUnit)
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsDel)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsPersonal)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsPublic)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.OwnerUnit)
                    .HasColumnType("varchar(1024)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProjectApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.ThumbnailUrl).HasColumnType("longtext");

                entity.Property(e => e.Title).HasColumnType("varchar(128)");
            });

            modelBuilder.Entity<BaseOrganizegis>(entity =>
            {
                entity.HasKey(e => e.BogGuid);

                entity.ToTable("base_organizegis");

                entity.Property(e => e.BogGuid)
                    .HasColumnName("bog_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BogHeight).HasColumnName("bog_height");

                entity.Property(e => e.BogLatitude).HasColumnName("bog_latitude");

                entity.Property(e => e.BogLongitude).HasColumnName("bog_longitude");

                entity.Property(e => e.BogOrganizeId)
                    .HasColumnName("bog_organizeId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseOrganizeplus>(entity =>
            {
                entity.HasKey(e => e.BopGuid);

                entity.ToTable("base_organizeplus");

                entity.Property(e => e.BopGuid)
                    .HasColumnName("bop_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BopModelId)
                    .HasColumnName("bop_modelId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BopModelphase)
                    .HasColumnName("bop_modelphase")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BopOrganizeId)
                    .HasColumnName("bop_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BopPlanId)
                    .HasColumnName("bop_planId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseOrgimg>(entity =>
            {
                entity.HasKey(e => e.BoiId);

                entity.ToTable("base_orgimg");

                entity.Property(e => e.BoiId)
                    .HasColumnName("boi_id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.BoiMiniimg)
                    .HasColumnName("boi_miniimg")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.BoiOriginimg)
                    .HasColumnName("boi_originimg")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.BoiSmallimgurl)
                    .HasColumnName("boi_smallimgurl")
                    .HasColumnType("longtext");

                entity.Property(e => e.OrganizeId)
                    .HasColumnName("organizeId")
                    .HasColumnType("char(50)");
            });

            modelBuilder.Entity<BaseProjectnews>(entity =>
            {
                entity.HasKey(e => e.BpnGuid);

                entity.ToTable("base_projectnews");

                entity.Property(e => e.BpnGuid)
                    .HasColumnName("bpn_guid")
                    .HasColumnType("char(36)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BpnContent)
                    .HasColumnName("bpn_content")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.BpnExtjson)
                    .HasColumnName("bpn_extjson")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BpnTitle)
                    .HasColumnName("bpn_title")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseProjectscore>(entity =>
            {
                entity.HasKey(e => e.ProjectScoreId);

                entity.ToTable("base_projectscore");

                entity.Property(e => e.ProjectScoreId)
                    .HasColumnName("ProjectScoreID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModelBulid).HasColumnType("int(11)");

                entity.Property(e => e.ModelButter).HasColumnType("int(11)");

                entity.Property(e => e.ModelComplex).HasColumnType("int(11)");

                entity.Property(e => e.ModelCovery).HasColumnType("int(11)");

                entity.Property(e => e.ModelPara).HasColumnType("int(11)");

                entity.Property(e => e.OrganizeId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Score).HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseProjecttemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("base_projecttemplate");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(100)");

                entity.Property(e => e.IsDel)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(100)");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.TemplateName).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<BasePublicextend>(entity =>
            {
                entity.HasKey(e => e.ExtendId);

                entity.ToTable("base_publicextend");

                entity.Property(e => e.ExtendId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Extend1)
                    .HasColumnName("Extend_1")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.Extend1Description)
                    .HasColumnName("Extend_1_Description")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Extend2)
                    .HasColumnName("Extend_2")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.Extend2Description)
                    .HasColumnName("Extend_2_Description")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Extend3)
                    .HasColumnName("Extend_3")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.Extend3Description)
                    .HasColumnName("Extend_3_Description")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Extend4)
                    .HasColumnName("Extend_4")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.Extend4Description)
                    .HasColumnName("Extend_4_Description")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Extend5)
                    .HasColumnName("Extend_5")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.Extend5Description)
                    .HasColumnName("Extend_5_Description")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Extend6)
                    .HasColumnName("Extend_6")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.Extend6Description)
                    .HasColumnName("Extend_6_Description")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrimaryId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseRelation>(entity =>
            {
                entity.HasKey(e => e.RelationId);

                entity.ToTable("base_relation");

                entity.Property(e => e.RelationId)
                    .HasColumnName("RelationID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BrDeleteMark)
                    .HasColumnName("BR_DeleteMark")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SourceId)
                    .IsRequired()
                    .HasColumnName("SourceID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TargetId)
                    .IsRequired()
                    .HasColumnName("TargetID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TargetType)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<BaseRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("base_role");

                entity.Property(e => e.RoleId).HasColumnType("varchar(50)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.IsProjectManager)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.IsPublic).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.OverdueTime).HasColumnType("datetime");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<BaseSchedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("base_schedule");

                entity.Property(e => e.ScheduleId).HasColumnType("varchar(50)");

                entity.Property(e => e.Category).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.Early).HasColumnType("int(11)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("varchar(50)");

                entity.Property(e => e.IsMailAlert).HasColumnType("int(11)");

                entity.Property(e => e.IsMobileAlert).HasColumnType("int(11)");

                entity.Property(e => e.IsWeChatAlert).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.ScheduleContent).HasColumnType("varchar(200)");

                entity.Property(e => e.ScheduleName).HasColumnType("varchar(50)");

                entity.Property(e => e.ScheduleState).HasColumnType("int(11)");

                entity.Property(e => e.Security)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("varchar(50)");

                entity.Property(e => e.TaskTypeId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseScheduleAttachment>(entity =>
            {
                entity.ToTable("base_schedule_attachment");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasColumnName("CreateUserID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FileExtensions)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FileName).HasColumnType("varchar(128)");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.FileSize).HasColumnType("varchar(50)");

                entity.Property(e => e.FileType).HasColumnType("varchar(50)");

                entity.Property(e => e.FileVersionId).HasColumnType("varchar(50)");

                entity.Property(e => e.IsDel).HasColumnType("int(4)");

                entity.Property(e => e.IsShare)
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScheduleId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseScheduleParticipant>(entity =>
            {
                entity.HasKey(e => e.OrganizedParticipantId);

                entity.ToTable("base_schedule_participant");

                entity.Property(e => e.OrganizedParticipantId)
                    .HasColumnName("Organized_participantId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1999-12-31 23:00:00'");

                entity.Property(e => e.Removed)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScheduleId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'1999-12-31 23:00:00'");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseSpecialpw>(entity =>
            {
                entity.HasKey(e => e.SpacialpwId);

                entity.ToTable("base_specialpw");

                entity.Property(e => e.SpacialpwId)
                    .HasColumnName("Spacialpw_ID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Specialpw)
                    .IsRequired()
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseTemplateFolder>(entity =>
            {
                entity.HasKey(e => e.TemplatefolderId);

                entity.ToTable("base_template_folder");

                entity.Property(e => e.TemplatefolderId)
                    .HasColumnName("TemplatefolderID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FolderJson)
                    .IsRequired()
                    .HasColumnName("folderJson")
                    .HasColumnType("varchar(10000)");

                entity.Property(e => e.TemplateId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("base_user");

                entity.Property(e => e.UserId).HasColumnType("varchar(50)");

                entity.Property(e => e.Account).HasColumnType("varchar(50)");

                entity.Property(e => e.AllowEndTime).HasColumnType("datetime");

                entity.Property(e => e.AllowStartTime).HasColumnType("datetime");

                entity.Property(e => e.AnswerQuestion).HasColumnType("varchar(50)");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CheckOnLine).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DataFrom)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.DepartmentId).HasColumnType("varchar(50)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.DutyId).HasColumnType("varchar(50)");

                entity.Property(e => e.DutyName).HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FirstVisit).HasColumnType("datetime");

                entity.Property(e => e.Gender).HasColumnType("int(11)");

                entity.Property(e => e.HeadIcon).HasColumnType("varchar(200)");

                entity.Property(e => e.LastVisit).HasColumnType("datetime");

                entity.Property(e => e.LockEndDate).HasColumnType("datetime");

                entity.Property(e => e.LockStartDate).HasColumnType("datetime");

                entity.Property(e => e.LogOnCount).HasColumnType("int(11)");

                entity.Property(e => e.Manager).HasColumnType("varchar(50)");

                entity.Property(e => e.ManagerId).HasColumnType("varchar(50)");

                entity.Property(e => e.Mobile).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Msn)
                    .HasColumnName("MSN")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NickName).HasColumnType("varchar(50)");

                entity.Property(e => e.Oicq)
                    .HasColumnName("OICQ")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OpenId).HasColumnType("varchar(50)");

                entity.Property(e => e.OrganizeId).HasColumnType("varchar(50)");

                entity.Property(e => e.Password).HasColumnType("varchar(50)");

                entity.Property(e => e.PostId).HasColumnType("varchar(50)");

                entity.Property(e => e.PostName).HasColumnType("varchar(50)");

                entity.Property(e => e.PreviousVisit).HasColumnType("datetime");

                entity.Property(e => e.Question).HasColumnType("varchar(50)");

                entity.Property(e => e.QuickQuery).HasColumnType("varchar(200)");

                entity.Property(e => e.RealName).HasColumnType("varchar(50)");

                entity.Property(e => e.RoleId).HasColumnType("varchar(50)");

                entity.Property(e => e.Secretkey).HasColumnType("varchar(50)");

                entity.Property(e => e.SecurityLevel).HasColumnType("int(11)");

                entity.Property(e => e.SimpleSpelling).HasColumnType("varchar(200)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.Telephone).HasColumnType("varchar(50)");

                entity.Property(e => e.UserOnLine).HasColumnType("int(11)");

                entity.Property(e => e.UserType).HasColumnType("varchar(50)");

                entity.Property(e => e.WeChat).HasColumnType("varchar(50)");

                entity.Property(e => e.WorkGroupId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseUserext>(entity =>
            {
                entity.HasKey(e => e.BueGuid);

                entity.ToTable("base_userext");

                entity.Property(e => e.BueGuid)
                    .HasColumnName("bue_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BueExistspjcnt)
                    .HasColumnName("bue_existspjcnt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BueTotalpjcnt)
                    .HasColumnName("bue_totalpjcnt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BueUpdatetime)
                    .HasColumnName("bue_updatetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BueUpdateuser)
                    .HasColumnName("bue_updateuser")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BueUserId)
                    .HasColumnName("bue_userId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseUserrelation>(entity =>
            {
                entity.HasKey(e => e.UserRelationId);

                entity.ToTable("base_userrelation");

                entity.Property(e => e.UserRelationId).HasColumnType("varchar(50)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.IsDefault).HasColumnType("int(11)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BaseUsertag>(entity =>
            {
                entity.HasKey(e => e.ButGuid);

                entity.ToTable("base_usertag");

                entity.Property(e => e.ButGuid)
                    .HasColumnName("but_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ButCompanyId)
                    .HasColumnName("but_companyId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ButUserId)
                    .HasColumnName("but_userId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BimcompAttach>(entity =>
            {
                entity.HasKey(e => e.BcaGuid);

                entity.ToTable("bimcomp_attach");

                entity.Property(e => e.BcaGuid)
                    .HasColumnName("bca_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfMd5)
                    .HasColumnName("bcf_md5")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaGuid)
                    .HasColumnName("bcfa_guid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BimcompCategory>(entity =>
            {
                entity.HasKey(e => e.BccGuid);

                entity.ToTable("bimcomp_category");

                entity.Property(e => e.BccGuid)
                    .HasColumnName("bcc_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BccCode)
                    .HasColumnName("bcc_code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BccCurlevelnumber)
                    .HasColumnName("bcc_curlevelnumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BccDescription)
                    .HasColumnName("bcc_description")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.BccName)
                    .HasColumnName("bcc_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BccOrganizeId)
                    .HasColumnName("bcc_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BccUpdatetime)
                    .HasColumnName("bcc_updatetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BimcompFamily>(entity =>
            {
                entity.HasKey(e => e.BcfaGuid);

                entity.ToTable("bimcomp_family");

                entity.Property(e => e.BcfaGuid)
                    .HasColumnName("bcfa_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BccGuid)
                    .HasColumnName("bcc_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfImgmd5)
                    .HasColumnName("bcf_imgmd5")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfMd5)
                    .HasColumnName("bcf_md5")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaDescription)
                    .HasColumnName("bcfa_description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaFilelogicname)
                    .HasColumnName("bcfa_filelogicname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaName)
                    .HasColumnName("bcfa_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaRefguid)
                    .HasColumnName("bcfa_refguid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaUpdatetime)
                    .HasColumnName("bcfa_updatetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BimcompFaprop>(entity =>
            {
                entity.HasKey(e => e.BcfapGuid);

                entity.ToTable("bimcomp_faprop");

                entity.Property(e => e.BcfapGuid)
                    .HasColumnName("bcfap_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaGuid)
                    .HasColumnName("bcfa_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfapModelnumber)
                    .HasColumnName("bcfap_modelnumber")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfapName)
                    .HasColumnName("bcfap_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfapValue)
                    .HasColumnName("bcfap_value")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfapcGuid)
                    .HasColumnName("bcfapc_guid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BimcompFapropcategory>(entity =>
            {
                entity.HasKey(e => e.BcfapcGuid);

                entity.ToTable("bimcomp_fapropcategory");

                entity.Property(e => e.BcfapcGuid)
                    .HasColumnName("bcfapc_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfapcName)
                    .HasColumnName("bcfapc_name")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BimcompFile>(entity =>
            {
                entity.HasKey(e => e.BcfMd5);

                entity.ToTable("bimcomp_file");

                entity.Property(e => e.BcfMd5)
                    .HasColumnName("bcf_md5")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfPath)
                    .HasColumnName("bcf_path")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.BcfSize)
                    .HasColumnName("bcf_size")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BimcompRelmodel>(entity =>
            {
                entity.HasKey(e => e.BcrmGuid);

                entity.ToTable("bimcomp_relmodel");

                entity.Property(e => e.BcrmGuid)
                    .HasColumnName("bcrm_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaGuid)
                    .HasColumnName("bcfa_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcrmModelid)
                    .HasColumnName("bcrm_modelid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BimcompReltag>(entity =>
            {
                entity.HasKey(e => e.BcrtGuid);

                entity.ToTable("bimcomp_reltag");

                entity.Property(e => e.BcrtGuid)
                    .HasColumnName("bcrt_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BcfaGuid)
                    .HasColumnName("bcfa_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BctGuid)
                    .HasColumnName("bct_guid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BimcompTag>(entity =>
            {
                entity.HasKey(e => e.BctGuid);

                entity.ToTable("bimcomp_tag");

                entity.Property(e => e.BctGuid)
                    .HasColumnName("bct_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BctName)
                    .HasColumnName("bct_name")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.BctOrganizeId)
                    .HasColumnName("bct_organizeId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CfgUrls>(entity =>
            {
                entity.HasKey(e => e.CuGuid);

                entity.ToTable("cfg_urls");

                entity.Property(e => e.CuGuid)
                    .HasColumnName("cu_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CuDesc)
                    .HasColumnName("cu_desc")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.CuEntcode)
                    .HasColumnName("cu_entcode")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CuUrl)
                    .HasColumnName("cu_url")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CuUrltype)
                    .HasColumnName("cu_urltype")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ClientCashbalance>(entity =>
            {
                entity.HasKey(e => e.CashBalanceId);

                entity.ToTable("client_cashbalance");

                entity.Property(e => e.CashBalanceId).HasColumnType("varchar(50)");

                entity.Property(e => e.Abstract).HasColumnType("varchar(200)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18,2)");

                entity.Property(e => e.CashAccount).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.Expenses).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.Receivable).HasColumnType("decimal(18,2)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ClientChance>(entity =>
            {
                entity.HasKey(e => e.ChanceId);

                entity.ToTable("client_chance");

                entity.Property(e => e.ChanceId).HasColumnType("varchar(50)");

                entity.Property(e => e.AlertDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertState).HasColumnType("int(11)");

                entity.Property(e => e.Amount).HasColumnType("decimal(18,0)");

                entity.Property(e => e.ChanceState).HasColumnType("int(11)");

                entity.Property(e => e.ChanceTypeId).HasColumnType("varchar(50)");

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.CompanyAddress).HasColumnType("varchar(200)");

                entity.Property(e => e.CompanyDesc).HasColumnType("varchar(2048)");

                entity.Property(e => e.CompanyName).HasColumnType("varchar(200)");

                entity.Property(e => e.CompanyNatureId).HasColumnType("varchar(50)");

                entity.Property(e => e.CompanySite).HasColumnType("varchar(50)");

                entity.Property(e => e.Contacts).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DealDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.Hobby).HasColumnType("varchar(200)");

                entity.Property(e => e.IsToCustom).HasColumnType("int(11)");

                entity.Property(e => e.Mobile).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Profit).HasColumnType("decimal(18,0)");

                entity.Property(e => e.Province).HasColumnType("varchar(50)");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SaleCost).HasColumnType("decimal(18,0)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.SourceId).HasColumnType("varchar(50)");

                entity.Property(e => e.StageId).HasColumnType("varchar(50)");

                entity.Property(e => e.SuccessRate).HasColumnType("decimal(18,0)");

                entity.Property(e => e.Tel).HasColumnType("varchar(50)");

                entity.Property(e => e.TraceUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.TraceUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Wechat).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ClientCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("client_customer");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(50)");

                entity.Property(e => e.AlertDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertState).HasColumnType("int(11)");

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.CompanyAddress).HasColumnType("varchar(200)");

                entity.Property(e => e.CompanyDesc).HasColumnType("varchar(2048)");

                entity.Property(e => e.CompanySite).HasColumnType("varchar(50)");

                entity.Property(e => e.Contact).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.CustDegreeId).HasColumnType("varchar(50)");

                entity.Property(e => e.CustIndustryId).HasColumnType("varchar(50)");

                entity.Property(e => e.CustLevelId).HasColumnType("varchar(50)");

                entity.Property(e => e.CustTypeId).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.Hobby).HasColumnType("varchar(50)");

                entity.Property(e => e.LegalPerson).HasColumnType("varchar(50)");

                entity.Property(e => e.Mobile).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Province).HasColumnType("varchar(50)");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ShortName).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.Tel).HasColumnType("varchar(50)");

                entity.Property(e => e.TraceUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.TraceUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Wechat).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ClientCustomercontact>(entity =>
            {
                entity.HasKey(e => e.CustomerContactId);

                entity.ToTable("client_customercontact");

                entity.Property(e => e.CustomerContactId).HasColumnType("varchar(50)");

                entity.Property(e => e.Contact).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.Fax).HasColumnType("varchar(50)");

                entity.Property(e => e.Gender).HasColumnType("int(11)");

                entity.Property(e => e.Hobby).HasColumnType("varchar(50)");

                entity.Property(e => e.Mobile).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.PostId).HasColumnType("varchar(50)");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.Tel).HasColumnType("varchar(50)");

                entity.Property(e => e.Wechat).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ClientExpenses>(entity =>
            {
                entity.HasKey(e => e.ExpensesId);

                entity.ToTable("client_expenses");

                entity.Property(e => e.ExpensesId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ExpensesAbstract).HasColumnType("varchar(200)");

                entity.Property(e => e.ExpensesAccount).HasColumnType("varchar(50)");

                entity.Property(e => e.ExpensesDate).HasColumnType("datetime");

                entity.Property(e => e.ExpensesObject).HasColumnType("int(11)");

                entity.Property(e => e.ExpensesPrice).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ExpensesType).HasColumnType("varchar(50)");

                entity.Property(e => e.Managers).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ClientInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("client_invoice");

                entity.Property(e => e.InvoiceId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.CustomerCode).HasColumnType("varchar(50)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(50)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.InvoiceContent).HasColumnType("varchar(2048)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ClientOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("client_order");

                entity.Property(e => e.OrderId).HasColumnType("varchar(50)");

                entity.Property(e => e.AbstractInfo).HasColumnType("varchar(200)");

                entity.Property(e => e.Accounts).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ContractCode).HasColumnType("varchar(50)");

                entity.Property(e => e.ContractFile).HasColumnType("varchar(200)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(50)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.DiscountSum).HasColumnType("decimal(18,2)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.OrderCode).HasColumnType("varchar(50)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode).HasColumnType("varchar(50)");

                entity.Property(e => e.PaymentState).HasColumnType("int(11)");

                entity.Property(e => e.ReceivedAmount).HasColumnType("decimal(18,2)");

                entity.Property(e => e.SaleCost).HasColumnType("decimal(18,2)");

                entity.Property(e => e.SellerId).HasColumnType("varchar(50)");

                entity.Property(e => e.SellerName).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ClientOrderentry>(entity =>
            {
                entity.HasKey(e => e.OrderEntryId);

                entity.ToTable("client_orderentry");

                entity.Property(e => e.OrderEntryId).HasColumnType("varchar(50)");

                entity.Property(e => e.Amount).HasColumnType("decimal(18,2)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.OrderId).HasColumnType("varchar(50)");

                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ProductCode).HasColumnType("varchar(50)");

                entity.Property(e => e.ProductId).HasColumnType("varchar(50)");

                entity.Property(e => e.ProductName).HasColumnType("varchar(200)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18,2)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Taxprice).HasColumnType("decimal(18,2)");

                entity.Property(e => e.UnitId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ClientReceivable>(entity =>
            {
                entity.HasKey(e => e.ReceivableId);

                entity.ToTable("client_receivable");

                entity.Property(e => e.ReceivableId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.OrderId).HasColumnType("varchar(50)");

                entity.Property(e => e.PaymentAccount).HasColumnType("varchar(50)");

                entity.Property(e => e.PaymentMode).HasColumnType("varchar(50)");

                entity.Property(e => e.PaymentPrice).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PaymentTime).HasColumnType("datetime");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ClientTrailrecord>(entity =>
            {
                entity.HasKey(e => e.TrailId);

                entity.ToTable("client_trailrecord");

                entity.Property(e => e.TrailId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectId).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectSort).HasColumnType("int(11)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.TrackContent).HasColumnType("varchar(200)");

                entity.Property(e => e.TrackTypeId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ComPdfCache>(entity =>
            {
                entity.ToTable("com_pdf_cache");

                entity.Property(e => e.ComPdfCacheId)
                    .HasColumnName("Com_pdf_cache_ID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CacheId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PdfId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<EmailAddressee>(entity =>
            {
                entity.HasKey(e => e.AddresseeId);

                entity.ToTable("email_addressee");

                entity.Property(e => e.AddresseeId).HasColumnType("varchar(50)");

                entity.Property(e => e.Backlog).HasColumnType("int(11)");

                entity.Property(e => e.CategoryId).HasColumnType("varchar(50)");

                entity.Property(e => e.ContentId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.IsHighlight).HasColumnType("int(11)");

                entity.Property(e => e.IsRead).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ReadCount).HasColumnType("int(11)");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.RecipientId).HasColumnType("varchar(50)");

                entity.Property(e => e.RecipientName).HasColumnType("varchar(50)");

                entity.Property(e => e.RecipientState).HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmailCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("email_category");

                entity.Property(e => e.CategoryId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmailContent>(entity =>
            {
                entity.HasKey(e => e.ContentId);

                entity.ToTable("email_content");

                entity.Property(e => e.ContentId).HasColumnType("varchar(50)");

                entity.Property(e => e.AddresssHtml).HasColumnType("longtext");

                entity.Property(e => e.BccsendHtml).HasColumnType("longtext");

                entity.Property(e => e.CategoryId).HasColumnType("varchar(50)");

                entity.Property(e => e.CopysendHtml).HasColumnType("longtext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EmailContent1)
                    .HasColumnName("EmailContent")
                    .HasColumnType("longtext");

                entity.Property(e => e.EmailType).HasColumnType("int(11)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.IsHighlight).HasColumnType("int(11)");

                entity.Property(e => e.IsReceipt).HasColumnType("int(11)");

                entity.Property(e => e.IsSmsReminder).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(50)");

                entity.Property(e => e.SendPriority).HasColumnType("varchar(50)");

                entity.Property(e => e.SendState).HasColumnType("int(11)");

                entity.Property(e => e.SenderId).HasColumnType("varchar(50)");

                entity.Property(e => e.SenderName).HasColumnType("varchar(50)");

                entity.Property(e => e.SenderTime).HasColumnType("datetime");

                entity.Property(e => e.Theme).HasColumnType("varchar(200)");

                entity.Property(e => e.ThemeColor).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Errno>(entity =>
            {
                entity.HasKey(e => e.EnGuid);

                entity.ToTable("errno");

                entity.Property(e => e.EnGuid)
                    .HasColumnName("en_guid")
                    .HasColumnType("char(50)");

                entity.Property(e => e.EnDescription)
                    .HasColumnName("en_description")
                    .HasColumnType("char(50)");

                entity.Property(e => e.EnErrno)
                    .HasColumnName("en_errno")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ExamCategory>(entity =>
            {
                entity.HasKey(e => e.EcGuid);

                entity.ToTable("exam_category");

                entity.Property(e => e.EcGuid)
                    .HasColumnName("ec_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EcCode)
                    .HasColumnName("ec_code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EcCurlevelnumber)
                    .HasColumnName("ec_curlevelnumber")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EcElementids)
                    .HasColumnName("ec_elementids")
                    .HasColumnType("longtext");

                entity.Property(e => e.EcName)
                    .HasColumnName("ec_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EcOrganizeId)
                    .HasColumnName("ec_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EcType)
                    .HasColumnName("ec_type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ImContent>(entity =>
            {
                entity.HasKey(e => e.ContentId);

                entity.ToTable("im_content");

                entity.Property(e => e.ContentId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.IsGroup).HasColumnType("int(11)");

                entity.Property(e => e.MsgContent).HasColumnType("varchar(200)");

                entity.Property(e => e.SendId).HasColumnType("varchar(50)");

                entity.Property(e => e.ToId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ImGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("im_group");

                entity.Property(e => e.GroupId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<ImRead>(entity =>
            {
                entity.HasKey(e => e.ReadId);

                entity.ToTable("im_read");

                entity.Property(e => e.ReadId).HasColumnType("varchar(50)");

                entity.Property(e => e.ContentId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ReadStatus).HasColumnType("int(11)");

                entity.Property(e => e.SendId).HasColumnType("varchar(50)");

                entity.Property(e => e.UserId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ImUsergroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.ToTable("im_usergroup");

                entity.Property(e => e.UserGroupId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.GroupId).HasColumnType("varchar(50)");

                entity.Property(e => e.UserId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<IssueStatus>(entity =>
            {
                entity.HasKey(e => e.IsGuid);

                entity.ToTable("issue_status");

                entity.Property(e => e.IsGuid)
                    .HasColumnName("is_guid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.IsDesc)
                    .HasColumnName("is_desc")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.IsName)
                    .HasColumnName("is_name")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IsSort)
                    .HasColumnName("is_sort")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<IssueTag>(entity =>
            {
                entity.HasKey(e => e.ItGuid);

                entity.ToTable("issue_tag");

                entity.Property(e => e.ItGuid)
                    .HasColumnName("it_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ItColor)
                    .HasColumnName("it_color")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ItName)
                    .HasColumnName("it_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ItOrganizeId)
                    .HasColumnName("it_organizeId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<IssueType>(entity =>
            {
                entity.HasKey(e => e.ItGuid);

                entity.ToTable("issue_type");

                entity.Property(e => e.ItGuid)
                    .HasColumnName("it_guid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ItName)
                    .HasColumnName("it_name")
                    .HasColumnType("char(255)");
            });

            modelBuilder.Entity<MsgMsg>(entity =>
            {
                entity.HasKey(e => e.MmGuid);

                entity.ToTable("msg_msg");

                entity.Property(e => e.MmGuid)
                    .HasColumnName("mm_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MmAuthor)
                    .HasColumnName("mm_author")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MmAuthorrealname)
                    .HasColumnName("mm_authorrealname")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MmCreatedatetime)
                    .HasColumnName("mm_createdatetime")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.MmObjid)
                    .HasColumnName("mm_objid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MmObjname)
                    .HasColumnName("mm_objname")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MmOrganizeid)
                    .HasColumnName("mm_organizeid")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.MmTriobjobjtype)
                    .HasColumnName("mm_triobjobjtype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MmTriobjtype)
                    .HasColumnName("mm_triobjtype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MmTritype)
                    .HasColumnName("mm_tritype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MmType)
                    .HasColumnName("mm_type")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<MsgMsgext>(entity =>
            {
                entity.HasKey(e => e.MmeGuid);

                entity.ToTable("msg_msgext");

                entity.Property(e => e.MmeGuid)
                    .HasColumnName("mme_guid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MmGuid)
                    .HasColumnName("mm_guid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MmeExtdata)
                    .HasColumnName("mme_extdata")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.MmeILogAndMsgType)
                    .HasColumnName("mme_iLogAndMsgType")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MmeProjectId)
                    .HasColumnName("mme_ProjectID")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<MsgUser>(entity =>
            {
                entity.HasKey(e => e.MuGuid);

                entity.ToTable("msg_user");

                entity.Property(e => e.MuGuid)
                    .HasColumnName("mu_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MmGuid)
                    .HasColumnName("mm_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MuHasalert)
                    .HasColumnName("mu_hasalert")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MuHasread)
                    .HasColumnName("mu_hasread")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<MtrOuterpage>(entity =>
            {
                entity.HasKey(e => e.MopGuid);

                entity.ToTable("mtr_outerpage");

                entity.Property(e => e.MopGuid)
                    .HasColumnName("mop_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MopItemguid)
                    .HasColumnName("mop_itemguid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MopUrl)
                    .HasColumnName("mop_url")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<OperLog>(entity =>
            {
                entity.HasKey(e => e.OlGuid);

                entity.ToTable("oper_log");

                entity.Property(e => e.OlGuid)
                    .HasColumnName("ol_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OlContent)
                    .HasColumnName("ol_content")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.OlDatetime)
                    .HasColumnName("ol_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OlObjId)
                    .HasColumnName("ol_objId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OlOperId)
                    .HasColumnName("ol_operId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OlType)
                    .HasColumnName("ol_type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<OrgUserorganize>(entity =>
            {
                entity.HasKey(e => e.OuoId);

                entity.ToTable("org_userorganize");

                entity.Property(e => e.OuoId)
                    .HasColumnName("ouoId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OuoOrganizeId)
                    .HasColumnName("ouoOrganizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OuoUserId)
                    .HasColumnName("ouoUserId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OuoUserProjectCount)
                    .HasColumnName("ouoUserProjectCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OuoUserProjectsCreated)
                    .HasColumnName("ouoUserProjectsCreated")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PanoramaBase>(entity =>
            {
                entity.HasKey(e => e.PbGuid);

                entity.ToTable("panorama_base");

                entity.Property(e => e.PbGuid)
                    .HasColumnName("pb_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PbGisinfo)
                    .HasColumnName("pb_gisinfo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PbIsdel)
                    .HasColumnName("pb_isdel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PbName)
                    .HasColumnName("pb_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PbOrganizeId)
                    .HasColumnName("pb_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PbUpdatetime)
                    .HasColumnName("pb_updatetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PbUrl)
                    .HasColumnName("pb_url")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<PanoramaPointinfo>(entity =>
            {
                entity.HasKey(e => e.PpGuid);

                entity.ToTable("panorama_pointinfo");

                entity.Property(e => e.PpGuid)
                    .HasColumnName("pp_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Pbguid)
                    .HasColumnName("pbguid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PpHotspot)
                    .HasColumnName("pp_hotspot")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PpName)
                    .HasColumnName("pp_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PpPos)
                    .HasColumnName("pp_pos")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PpPosv2)
                    .HasColumnName("pp_posv2")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PpScene)
                    .HasColumnName("pp_scene")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<PlusProject>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("plus_project");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID_")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Calendars)
                    .HasColumnName("CALENDARS_")
                    .HasColumnType("text");

                entity.Property(e => e.Calendaruid)
                    .HasColumnName("CALENDARUID_")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Finishdate)
                    .HasColumnName("FINISHDATE_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastsaved)
                    .HasColumnName("LASTSAVED_")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME_")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE_")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PlusrelTaskelements>(entity =>
            {
                entity.HasKey(e => e.PteGuid);

                entity.ToTable("plusrel_taskelements");

                entity.Property(e => e.PteGuid)
                    .HasColumnName("pte_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PteCreatetime)
                    .HasColumnName("pte_createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PteElementids)
                    .HasColumnName("pte_elementids")
                    .HasColumnType("longtext");

                entity.Property(e => e.PtePlanid)
                    .HasColumnName("pte_planid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PteTaskid)
                    .HasColumnName("pte_taskid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PteUpdatetime)
                    .HasColumnName("pte_updatetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PlusResource>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("plus_resource");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID_")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Cost)
                    .HasColumnName("COST_")
                    .HasColumnType("double(15,3)");

                entity.Property(e => e.Maxunits)
                    .HasColumnName("MAXUNITS_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME_")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Projectuid)
                    .HasColumnName("PROJECTUID_")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Work)
                    .HasColumnName("WORK_")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlusTask3>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("plus_task3");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID_")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Actualduration)
                    .HasColumnName("ACTUALDURATION_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actualfinish)
                    .HasColumnName("ACTUALFINISH_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Actualstart)
                    .HasColumnName("ACTUALSTART_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Assignments)
                    .HasColumnName("ASSIGNMENTS_")
                    .HasColumnType("varchar(5000)");

                entity.Property(e => e.Constraintdate)
                    .HasColumnName("CONSTRAINTDATE_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Constrainttype)
                    .HasColumnName("CONSTRAINTTYPE_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Critical)
                    .HasColumnName("CRITICAL_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Critical2)
                    .HasColumnName("CRITICAL2_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Department)
                    .HasColumnName("DEPARTMENT_")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Duration)
                    .HasColumnName("DURATION_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Finish)
                    .HasColumnName("FINISH_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fixeddate)
                    .HasColumnName("FIXEDDATE_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Manual)
                    .HasColumnName("MANUAL_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Milestone)
                    .HasColumnName("MILESTONE_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME_")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES_")
                    .HasColumnType("varchar(10000)");

                entity.Property(e => e.Parenttaskuid)
                    .IsRequired()
                    .HasColumnName("PARENTTASKUID_")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Percentcomplete)
                    .HasColumnName("PERCENTCOMPLETE_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Predecessorlink)
                    .HasColumnName("PREDECESSORLINK_")
                    .HasColumnType("varchar(10000)");

                entity.Property(e => e.Principal)
                    .HasColumnName("PRINCIPAL_")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Projectuid)
                    .HasColumnName("PROJECTUID_")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Start)
                    .HasColumnName("START_")
                    .HasColumnType("datetime");

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Wbs)
                    .HasColumnName("WBS_")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT_")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Work)
                    .HasColumnName("WORK_")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RelIssueIssueuser>(entity =>
            {
                entity.HasKey(e => e.RiiuGuid);

                entity.ToTable("rel_issue_issueuser");

                entity.Property(e => e.RiiuGuid)
                    .HasColumnName("riiu_guid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RiiuIssueid)
                    .IsRequired()
                    .HasColumnName("riiu_issueid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RiiuReltype)
                    .IsRequired()
                    .HasColumnName("riiu_reltype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RiiuUserid)
                    .IsRequired()
                    .HasColumnName("riiu_userid")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<RelIssueTag>(entity =>
            {
                entity.HasKey(e => e.RitGuid);

                entity.ToTable("rel_issue_tag");

                entity.Property(e => e.RitGuid)
                    .HasColumnName("rit_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RitIssueid)
                    .HasColumnName("rit_issueid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RitTagIds)
                    .HasColumnName("rit_tagIds")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<RptTemp>(entity =>
            {
                entity.HasKey(e => e.TempId);

                entity.ToTable("rpt_temp");

                entity.Property(e => e.TempId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnCode).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FullName).HasColumnType("varchar(200)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ParamJson).HasColumnType("varchar(5000)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.TempCategory).HasColumnType("varchar(50)");

                entity.Property(e => e.TempType).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SharedModel>(entity =>
            {
                entity.HasKey(e => e.ShmGuid);

                entity.ToTable("shared_model");

                entity.Property(e => e.ShmGuid)
                    .HasColumnName("shm_guid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ShmCreateUserId)
                    .HasColumnName("shm_createUserId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ShmCreatedate)
                    .HasColumnName("shm_createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShmHaspwd)
                    .HasColumnName("shm_haspwd")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ShmJson)
                    .HasColumnName("shm_json")
                    .HasColumnType("longtext");

                entity.Property(e => e.ShmModelid)
                    .HasColumnName("shm_modelid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ShmModelversion)
                    .HasColumnName("shm_modelversion")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ShmOriginpwd)
                    .HasColumnName("shm_originpwd")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ShmProjectid)
                    .HasColumnName("shm_projectid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ShmPwd)
                    .HasColumnName("shm_pwd")
                    .HasColumnType("char(128)");

                entity.Property(e => e.ShmSessionId)
                    .HasColumnName("shm_sessionId")
                    .HasColumnType("char(36)");
            });

            modelBuilder.Entity<SyncMaterialarrange>(entity =>
            {
                entity.HasKey(e => e.SmaGuid);

                entity.ToTable("sync_materialarrange");

                entity.Property(e => e.SmaGuid)
                    .HasColumnName("sma_guid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SmaBcguid)
                    .HasColumnName("sma_bcguid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SmaHadarrange)
                    .HasColumnName("sma_hadarrange")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SmaOrganizeId)
                    .HasColumnName("sma_organizeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SmaPath)
                    .HasColumnName("sma_path")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SmaUploadtime)
                    .HasColumnName("sma_uploadtime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WechatApp>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("wechat_app");

                entity.Property(e => e.AppId).HasColumnType("varchar(50)");

                entity.Property(e => e.AppLogo).HasColumnType("varchar(200)");

                entity.Property(e => e.AppName).HasColumnType("varchar(50)");

                entity.Property(e => e.AppType).HasColumnType("int(11)");

                entity.Property(e => e.AppUrl).HasColumnType("varchar(200)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.IsReportUser).HasColumnType("int(11)");

                entity.Property(e => e.IsReportenter).HasColumnType("int(11)");

                entity.Property(e => e.MenuJson).HasColumnType("varchar(5000)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.RedirectDomain).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<WechatDeptrelation>(entity =>
            {
                entity.HasKey(e => e.DeptRelationId);

                entity.ToTable("wechat_deptrelation");

                entity.Property(e => e.DeptRelationId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeptId).HasColumnType("varchar(50)");

                entity.Property(e => e.DeptName).HasColumnType("varchar(50)");

                entity.Property(e => e.WeChatDeptId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<WechatUserrelation>(entity =>
            {
                entity.HasKey(e => e.UserRelationId);

                entity.ToTable("wechat_userrelation");

                entity.Property(e => e.UserRelationId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeptId).HasColumnType("varchar(50)");

                entity.Property(e => e.DeptName).HasColumnType("varchar(50)");

                entity.Property(e => e.SyncLog).HasColumnType("varchar(200)");

                entity.Property(e => e.SyncState).HasColumnType("varchar(50)");

                entity.Property(e => e.UserId).HasColumnType("varchar(50)");

                entity.Property(e => e.WeChatDeptId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<WfDelegaterecord>(entity =>
            {
                entity.ToTable("wf_delegaterecord");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.FromUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.ProcessCode).HasColumnType("varchar(200)");

                entity.Property(e => e.ProcessId).HasColumnType("varchar(50)");

                entity.Property(e => e.ProcessName).HasColumnType("varchar(200)");

                entity.Property(e => e.ToUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ToUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.WfdelegateRuleId)
                    .IsRequired()
                    .HasColumnName("WFDelegateRuleId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfDelegaterule>(entity =>
            {
                entity.ToTable("wf_delegaterule");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.Description).HasColumnType("varchar(50)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ToUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ToUserName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfDelegateruleschemeinfo>(entity =>
            {
                entity.ToTable("wf_delegateruleschemeinfo");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.DelegateRuleId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeInfoId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfFieldcfg>(entity =>
            {
                entity.ToTable("wf_fieldcfg");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.AuthJson).HasColumnType("varchar(50)");

                entity.Property(e => e.FrmMainId).HasColumnType("varchar(50)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.NodeId).HasColumnType("varchar(50)");

                entity.Property(e => e.ScId)
                    .HasColumnName("sc_id")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfFlowinstance>(entity =>
            {
                entity.HasKey(e => e.WfiId);

                entity.ToTable("wf_flowinstance");

                entity.Property(e => e.WfiId)
                    .HasColumnName("WFI_Id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ScId)
                    .HasColumnName("SC_Id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfiActiveNodeIds)
                    .HasColumnName("WFI_ActiveNodeIds")
                    .HasColumnType("text");

                entity.Property(e => e.WfiAllOperators)
                    .HasColumnName("WFI_AllOperators")
                    .HasColumnType("text");

                entity.Property(e => e.WfiCreateTime)
                    .HasColumnName("WFI_CreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.WfiCreateUser)
                    .HasColumnName("WFI_CreateUser")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfiFormData)
                    .HasColumnName("WFI_FormData")
                    .HasColumnType("longtext");

                entity.Property(e => e.WfiNextOperators)
                    .HasColumnName("WFI_NextOperators")
                    .HasColumnType("text");

                entity.Property(e => e.WfiNexts)
                    .HasColumnName("WFI_Nexts")
                    .HasColumnType("longtext");

                entity.Property(e => e.WfiStatus)
                    .HasColumnName("WFI_Status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WfiTitle)
                    .HasColumnName("WFI_Title")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.WfiUniqueId)
                    .HasColumnName("WFI_UniqueId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfiUpdateTime)
                    .HasColumnName("WFI_UpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WfFlowinstanceactive>(entity =>
            {
                entity.HasKey(e => e.WfiaId);

                entity.ToTable("wf_flowinstanceactive");

                entity.Property(e => e.WfiaId)
                    .HasColumnName("wfia_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfiId)
                    .HasColumnName("WFI_Id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfiaNextoperators)
                    .HasColumnName("wfia_nextoperators")
                    .HasColumnType("longtext");

                entity.Property(e => e.WfiaNodeid)
                    .HasColumnName("wfia_nodeid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfFlowrecord>(entity =>
            {
                entity.HasKey(e => e.WfrId);

                entity.ToTable("wf_flowrecord");

                entity.Property(e => e.WfrId)
                    .HasColumnName("WFR_ID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfiId)
                    .HasColumnName("WFI_Id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfrCnodeId)
                    .HasColumnName("WFR_CNodeId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfrComments)
                    .HasColumnName("WFR_Comments")
                    .HasColumnType("longtext");

                entity.Property(e => e.WfrCreatetime)
                    .HasColumnName("WFR_Createtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.WfrFormData)
                    .HasColumnName("WFR_FormData")
                    .HasColumnType("longtext");

                entity.Property(e => e.WfrOperateResult)
                    .HasColumnName("WFR_OperateResult")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfrOperator)
                    .HasColumnName("WFR_Operator")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfrPnodeId)
                    .HasColumnName("WFR_PNodeId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfFrmmain>(entity =>
            {
                entity.HasKey(e => e.FrmMainId);

                entity.ToTable("wf_frmmain");

                entity.Property(e => e.FrmMainId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FrmCode).HasColumnType("varchar(50)");

                entity.Property(e => e.FrmContent).HasColumnType("longtext");

                entity.Property(e => e.FrmDbId).HasColumnType("varchar(50)");

                entity.Property(e => e.FrmExtrajson).HasColumnType("longtext");

                entity.Property(e => e.FrmName).HasColumnType("varchar(200)");

                entity.Property(e => e.FrmTable).HasColumnType("text");

                entity.Property(e => e.FrmTableId).HasColumnType("varchar(50)");

                entity.Property(e => e.FrmType).HasColumnType("varchar(50)");

                entity.Property(e => e.IsSystemTable).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<WfLinebtns>(entity =>
            {
                entity.HasKey(e => e.WlbId);

                entity.ToTable("wf_linebtns");

                entity.Property(e => e.WlbId)
                    .HasColumnName("wlb_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WlbBtnname)
                    .HasColumnName("wlb_btnname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WlbLineid)
                    .HasColumnName("wlb_lineid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WlbLineobj)
                    .HasColumnName("wlb_lineobj")
                    .HasColumnType("longtext");

                entity.Property(e => e.WlbLinetype)
                    .HasColumnName("wlb_linetype")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WlbScid)
                    .HasColumnName("wlb_scid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfNodedatas>(entity =>
            {
                entity.HasKey(e => e.WndId);

                entity.ToTable("wf_nodedatas");

                entity.Property(e => e.WndId)
                    .HasColumnName("wnd_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WndJson)
                    .HasColumnName("wnd_json")
                    .HasColumnType("longtext");

                entity.Property(e => e.WndNodeid)
                    .HasColumnName("wnd_nodeid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WndScid)
                    .HasColumnName("wnd_scid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfProcessinstance>(entity =>
            {
                entity.ToTable("wf_processinstance");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.ActivityId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ActivityType).HasColumnType("int(11)");

                entity.Property(e => e.BimcomposerId)
                    .HasColumnName("BIMComposerID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CustomName).HasColumnType("varchar(200)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FrmType).HasColumnType("int(11)");

                entity.Property(e => e.IsFinish).HasColumnType("int(11)");

                entity.Property(e => e.Level).HasColumnType("int(11)");

                entity.Property(e => e.MakerList).HasColumnType("varchar(1000)");

                entity.Property(e => e.PreviousId).HasColumnType("varchar(50)");

                entity.Property(e => e.ProcessSchemeId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeType)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfProcessoperationhistory>(entity =>
            {
                entity.ToTable("wf_processoperationhistory");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ProcessId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfProcessscheme>(entity =>
            {
                entity.ToTable("wf_processscheme");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.ElementId)
                    .HasColumnName("ElementID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ProcessType).HasColumnType("int(11)");

                entity.Property(e => e.SchemeContent).HasColumnType("text");

                entity.Property(e => e.SchemeVersion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SpaceId)
                    .HasColumnName("SpaceID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ViewpointId)
                    .HasColumnName("ViewpointID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfschemeInfoId)
                    .IsRequired()
                    .HasColumnName("WFSchemeInfoId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfProcesstransitionhistory>(entity =>
            {
                entity.ToTable("wf_processtransitionhistory");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FromNodeId).HasColumnType("varchar(1024)");

                entity.Property(e => e.FromNodeName).HasColumnType("varchar(200)");

                entity.Property(e => e.FromNodeType).HasColumnType("int(11)");

                entity.Property(e => e.IsFinish).HasColumnType("int(11)");

                entity.Property(e => e.ProcessId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ToNodeId).HasColumnType("varchar(50)");

                entity.Property(e => e.ToNodeName).HasColumnType("varchar(200)");

                entity.Property(e => e.ToNodeType).HasColumnType("int(11)");

                entity.Property(e => e.TransitionSate).HasColumnType("int(11)");
            });

            modelBuilder.Entity<WfProjectschemerelation>(entity =>
            {
                entity.HasKey(e => e.RelationId);

                entity.ToTable("wf_projectschemerelation");

                entity.Property(e => e.RelationId).HasColumnType("varchar(50)");

                entity.Property(e => e.BimcomposerId)
                    .HasColumnName("BIMComposerID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeInfoId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfSchemecontent>(entity =>
            {
                entity.ToTable("wf_schemecontent");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeContent).HasColumnType("text");

                entity.Property(e => e.SchemeVersion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WfcShuntPairs)
                    .HasColumnName("WFC_ShuntPairs")
                    .HasColumnType("longtext");

                entity.Property(e => e.WfschemeInfoId)
                    .IsRequired()
                    .HasColumnName("WFSchemeInfoId")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<WfSchemeinfo>(entity =>
            {
                entity.ToTable("wf_schemeinfo");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.AuthorizeType).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DeleteMark).HasColumnType("int(11)");

                entity.Property(e => e.DependentCategory)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.EnabledMark).HasColumnType("int(11)");

                entity.Property(e => e.FrmType).HasColumnType("int(11)");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyUserName).HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeCanUser).HasColumnType("varchar(2048)");

                entity.Property(e => e.SchemeCode).HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeName).HasColumnType("varchar(200)");

                entity.Property(e => e.SchemeTemplateType)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SchemeType).HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeVersion).HasColumnType("varchar(50)");

                entity.Property(e => e.SortCode).HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WfSchemeinfoauthorize>(entity =>
            {
                entity.ToTable("wf_schemeinfoauthorize");

                entity.Property(e => e.Id).HasColumnType("varchar(50)");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SchemeInfoId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });
        }
    }
}

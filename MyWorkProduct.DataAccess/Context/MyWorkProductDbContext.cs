using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MyWorkProduct.DataAccess.Models;

#nullable disable

namespace MyWorkProduct.DataAccess.Context
{
    public partial class MyWorkProductDbContext : DbContext
    {
        public MyWorkProductDbContext()
        {
        }

        public MyWorkProductDbContext(DbContextOptions<MyWorkProductDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionList> ActionLists { get; set; }
        public virtual DbSet<AuditTrailMaster> AuditTrailMasters { get; set; }
        public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientConfigEntity> ClientConfigEntities { get; set; }
        public virtual DbSet<ClientConfiguration> ClientConfigurations { get; set; }
        public virtual DbSet<ClientProvider> ClientProviders { get; set; }
        public virtual DbSet<ClientTitle> ClientTitles { get; set; }
        public virtual DbSet<ClientUserRole> ClientUserRoles { get; set; }
        public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; }
        public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentBranch> DepartmentBranches { get; set; }
        public virtual DbSet<Kaizen> Kaizens { get; set; }
        public virtual DbSet<KaizenConfig> KaizenConfigs { get; set; }
        public virtual DbSet<KaizenItem> KaizenItems { get; set; }
        public virtual DbSet<KaizenSecondCat> KaizenSecondCats { get; set; }
        public virtual DbSet<KaizenTopCat> KaizenTopCats { get; set; }
        public virtual DbSet<KaizenUserScoreAttempt> KaizenUserScoreAttempts { get; set; }
        public virtual DbSet<KaizenVoteScore> KaizenVoteScores { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MultiUserReport> MultiUserReports { get; set; }
        public virtual DbSet<NotificationGlobalSubscription> NotificationGlobalSubscriptions { get; set; }
        public virtual DbSet<NotificationItem> NotificationItems { get; set; }
        public virtual DbSet<NotificationLog> NotificationLogs { get; set; }
        public virtual DbSet<NotificationLogDevice> NotificationLogDevices { get; set; }
        public virtual DbSet<NotificationMaster> NotificationMasters { get; set; }
        public virtual DbSet<NotificationSuscription> NotificationSuscriptions { get; set; }
        public virtual DbSet<OrganizationHierarchy> OrganizationHierarchies { get; set; }
        public virtual DbSet<PasswordChangeRequest> PasswordChangeRequests { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Playbook> Playbooks { get; set; }
        public virtual DbSet<PlaybookDocument> PlaybookDocuments { get; set; }
        public virtual DbSet<PlaybookFavorite> PlaybookFavorites { get; set; }
        public virtual DbSet<PlaybookLink> PlaybookLinks { get; set; }
        public virtual DbSet<PlaybookMaster> PlaybookMasters { get; set; }
        public virtual DbSet<PlaybookNew> PlaybookNews { get; set; }
        public virtual DbSet<ProcessJob> ProcessJobs { get; set; }
        public virtual DbSet<ProcessesMaster> ProcessesMasters { get; set; }
        public virtual DbSet<ProcessesStep> ProcessesSteps { get; set; }
        public virtual DbSet<ProductUpdate> ProductUpdates { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<ProviderStorageAccountType> ProviderStorageAccountTypes { get; set; }
        public virtual DbSet<ReportDocLog> ReportDocLogs { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplates { get; set; }
        public virtual DbSet<ReportTemplateAssignment> ReportTemplateAssignments { get; set; }
        public virtual DbSet<ReportTemplateAssignmentAssignee> ReportTemplateAssignmentAssignees { get; set; }
        public virtual DbSet<ReportTemplateFavorite> ReportTemplateFavorites { get; set; }
        public virtual DbSet<ReportTemplateLog> ReportTemplateLogs { get; set; }
        public virtual DbSet<ReportTemplateSection> ReportTemplateSections { get; set; }
        public virtual DbSet<ResetAudit> ResetAudits { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceAvailStatus> ResourceAvailStatuses { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ScheduleItem> ScheduleItems { get; set; }
        public virtual DbSet<ScheduleItemsDetail> ScheduleItemsDetails { get; set; }
        public virtual DbSet<SecretQuestion> SecretQuestions { get; set; }
        public virtual DbSet<SiteLink> SiteLinks { get; set; }
        public virtual DbSet<SiteNavigation> SiteNavigations { get; set; }
        public virtual DbSet<SqueezeAggregate> SqueezeAggregates { get; set; }
        public virtual DbSet<StorageAccountType> StorageAccountTypes { get; set; }
        public virtual DbSet<TaskOwnerLookup> TaskOwnerLookups { get; set; }
        public virtual DbSet<TaskReportTemplate> TaskReportTemplates { get; set; }
        public virtual DbSet<TaskStatus> TaskStatuses { get; set; }
        public virtual DbSet<TaskType> TaskTypes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamFavorite> TeamFavorites { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<TemplateTaskCategory> TemplateTaskCategories { get; set; }
        public virtual DbSet<TemplateTaskCategoryType> TemplateTaskCategoryTypes { get; set; }
        public virtual DbSet<TemplateTaskNew> TemplateTaskNews { get; set; }
        public virtual DbSet<TemplateTaskNewFavorite> TemplateTaskNewFavorites { get; set; }
        public virtual DbSet<TemplateTaskPlaybookDocument> TemplateTaskPlaybookDocuments { get; set; }
        public virtual DbSet<TemplateTaskResource> TemplateTaskResources { get; set; }
        public virtual DbSet<Tip> Tips { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAvailableStatus> UserAvailableStatuses { get; set; }
        public virtual DbSet<UserConfiguration> UserConfigurations { get; set; }
        public virtual DbSet<UserDocumentPermission> UserDocumentPermissions { get; set; }
        public virtual DbSet<UserMessaging> UserMessagings { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<UserProfileChangeTrace> UserProfileChangeTraces { get; set; }
        public virtual DbSet<UserSecretAnswer> UserSecretAnswers { get; set; }
        public virtual DbSet<UserSqueeze> UserSqueezes { get; set; }
        public virtual DbSet<UserStorageAccountType> UserStorageAccountTypes { get; set; }
        public virtual DbSet<UserTask> UserTasks { get; set; }
        public virtual DbSet<UserTaskAdditionalOwner> UserTaskAdditionalOwners { get; set; }
        public virtual DbSet<UserTaskApprovalRequeriment> UserTaskApprovalRequeriments { get; set; }
        public virtual DbSet<UserTaskComment> UserTaskComments { get; set; }
        public virtual DbSet<UserTaskDocument> UserTaskDocuments { get; set; }
        public virtual DbSet<UserTaskLastSeen> UserTaskLastSeens { get; set; }
        public virtual DbSet<UserTaskPlaybookDocument> UserTaskPlaybookDocuments { get; set; }
        public virtual DbSet<UserTaskResource> UserTaskResources { get; set; }
        public virtual DbSet<UserTaskTracer> UserTaskTracers { get; set; }
        public virtual DbSet<UserTitle> UserTitles { get; set; }
        public virtual DbSet<UserTitlePermission> UserTitlePermissions { get; set; }
        public virtual DbSet<UsersManager> UsersManagers { get; set; }
        public virtual DbSet<Usstate> Usstates { get; set; }
        public virtual DbSet<VoteType> VoteTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TU0C0U0;Database=MyWorkProductDb;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActionList>(entity =>
            {
                entity.HasKey(e => e.ActionItemId)
                    .HasName("PK__ActionLi__56285AD2685CA4C6");

                entity.ToTable("ActionList");

                entity.Property(e => e.ActionItemId).HasColumnName("ActionItemID");

                entity.Property(e => e.ActionDescription).HasMaxLength(500);

                entity.Property(e => e.ActionName).HasMaxLength(100);
            });

            modelBuilder.Entity<AuditTrailMaster>(entity =>
            {
                entity.HasKey(e => e.AuditTrailId)
                    .HasName("PK__AuditTra__41B2DDD3EC20BF37");

                entity.ToTable("AuditTrailMaster");

                entity.Property(e => e.AuditTrailId).HasColumnName("AuditTrailID");

                entity.Property(e => e.TaskDescription).HasMaxLength(500);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CalendarEvent>(entity =>
            {
                entity.Property(e => e.CalendarEventId).HasColumnName("CalendarEventID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Repeat)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatOptions)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatUntil).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UserTaskId).HasColumnName("UserTaskID");

                entity.HasOne(d => d.BelongsToUserNavigation)
                    .WithMany(p => p.CalendarEvents)
                    .HasForeignKey(d => d.BelongsToUser)
                    .HasConstraintName("FK_CalendarEvents_Users");

                entity.HasOne(d => d.UserTask)
                    .WithMany(p => p.CalendarEvents)
                    .HasForeignKey(d => d.UserTaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CalendarEvents_UserTaskID");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.AddressLine1).HasMaxLength(500);

                entity.Property(e => e.AddressLine2).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.ClientBranding).HasMaxLength(500);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ClientTitle).HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LogoPath).HasMaxLength(2500);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<ClientConfigEntity>(entity =>
            {
                entity.Property(e => e.ClientConfigEntityId).HasColumnName("ClientConfigEntityID");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EntityName).HasMaxLength(2000);
            });

            modelBuilder.Entity<ClientConfiguration>(entity =>
            {
                entity.HasKey(e => e.ClientConfigId);

                entity.ToTable("ClientConfiguration");

                entity.Property(e => e.ClientConfigId).HasColumnName("ClientConfigID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.EntityValue).HasMaxLength(1000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientConfigurations)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_ClientConfiguration_Client");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.ClientConfigurations)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_ClientConfiguration_ClientConfigEntities");
            });

            modelBuilder.Entity<ClientProvider>(entity =>
            {
                entity.HasKey(e => new { e.ProviderId, e.ClientId });

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProviders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientProviders_Clients");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ClientProviders)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientProviders_Providers");
            });

            modelBuilder.Entity<ClientTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId)
                    .HasName("PK_Titles");

                entity.Property(e => e.TitleId).HasColumnName("TitleID");

                entity.Property(e => e.Archived)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ColorFrom).HasMaxLength(12);

                entity.Property(e => e.ColorTo).HasMaxLength(12);

                entity.Property(e => e.TitleName).HasMaxLength(100);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientTitles)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientTitles_Clients");
            });

            modelBuilder.Entity<ClientUserRole>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientUserRoles)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_ClientUserRoles_Clients");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ClientUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_ClientUserRoles_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClientUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ClientUserRoles_Users");
            });

            modelBuilder.Entity<Databasechangelog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATABASECHANGELOG");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.Contexts)
                    .HasMaxLength(255)
                    .HasColumnName("CONTEXTS");

                entity.Property(e => e.Dateexecuted)
                    .HasPrecision(3)
                    .HasColumnName("DATEEXECUTED");

                entity.Property(e => e.DeploymentId)
                    .HasMaxLength(10)
                    .HasColumnName("DEPLOYMENT_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Exectype)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("EXECTYPE");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("FILENAME");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.Labels)
                    .HasMaxLength(255)
                    .HasColumnName("LABELS");

                entity.Property(e => e.Liquibase)
                    .HasMaxLength(20)
                    .HasColumnName("LIQUIBASE");

                entity.Property(e => e.Md5sum)
                    .HasMaxLength(35)
                    .HasColumnName("MD5SUM");

                entity.Property(e => e.Orderexecuted).HasColumnName("ORDEREXECUTED");

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .HasColumnName("TAG");
            });

            modelBuilder.Entity<Databasechangeloglock>(entity =>
            {
                entity.ToTable("DATABASECHANGELOGLOCK");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Locked).HasColumnName("LOCKED");

                entity.Property(e => e.Lockedby)
                    .HasMaxLength(255)
                    .HasColumnName("LOCKEDBY");

                entity.Property(e => e.Lockgranted)
                    .HasPrecision(3)
                    .HasColumnName("LOCKGRANTED");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DepartmentName).HasMaxLength(500);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Departments_Clients");
            });

            modelBuilder.Entity<DepartmentBranch>(entity =>
            {
                entity.Property(e => e.DepartmentBranchId).HasColumnName("DepartmentBranchID");

                entity.Property(e => e.BranchAddressLine1).HasMaxLength(50);

                entity.Property(e => e.BranchAddressLine2).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Zip).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentBranches)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_DepartmentBranches_Departments");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.DepartmentBranches)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_DepartmentBranches_USStates");
            });

            modelBuilder.Entity<Kaizen>(entity =>
            {
                entity.ToTable("Kaizen");

                entity.Property(e => e.KaizenId).HasColumnName("KaizenID");

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.How).HasColumnName("how");

                entity.Property(e => e.KaizenTitle).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SubmittedByUserId).HasColumnName("SubmittedByUserID");

                entity.Property(e => e.What1).HasColumnName("what1");

                entity.Property(e => e.What2).HasColumnName("what2");

                entity.Property(e => e.Why1).HasColumnName("why1");

                entity.Property(e => e.Why2).HasColumnName("why2");

                entity.Property(e => e.Why3).HasColumnName("why3");

                entity.Property(e => e.Why4).HasColumnName("why4");

                entity.Property(e => e.Why5).HasColumnName("why5");

                entity.HasOne(d => d.KaizenSecondCatNavigation)
                    .WithMany(p => p.Kaizens)
                    .HasForeignKey(d => d.KaizenSecondCat)
                    .HasConstraintName("FK_Kaizen_KaizenSecondCat");

                entity.HasOne(d => d.KaizenTopCatNavigation)
                    .WithMany(p => p.Kaizens)
                    .HasForeignKey(d => d.KaizenTopCat)
                    .HasConstraintName("FK_Kaizen_KaizenTopCat");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Kaizen_Kaizen");

                entity.HasOne(d => d.SubmittedByUser)
                    .WithMany(p => p.Kaizens)
                    .HasForeignKey(d => d.SubmittedByUserId)
                    .HasConstraintName("FK_Kaizen_Users");
            });

            modelBuilder.Entity<KaizenConfig>(entity =>
            {
                entity.ToTable("KaizenConfig");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ScoreForDescription).HasColumnName("scoreForDescription");

                entity.Property(e => e.ScoreForEachAttach).HasColumnName("scoreForEachAttach");

                entity.Property(e => e.ScoreForEachWhy).HasColumnName("scoreForEachWhy");

                entity.Property(e => e.ScoreForQuestion1).HasColumnName("scoreForQuestion1");

                entity.Property(e => e.ScoreForQuestion2).HasColumnName("scoreForQuestion2");

                entity.Property(e => e.ScoreForQuestion3).HasColumnName("scoreForQuestion3");

                entity.Property(e => e.ScoreForTitle).HasColumnName("scoreForTitle");
            });

            modelBuilder.Entity<KaizenItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Attachments)
                    .IsUnicode(false)
                    .HasColumnName("attachments");

                entity.Property(e => e.Category1).HasColumnName("category1");

                entity.Property(e => e.Category2).HasColumnName("category2");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.How).HasColumnName("how");

                entity.Property(e => e.KaizenItemParentId).HasColumnName("kaizenItemParentId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasColumnName("visible")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.What1).HasColumnName("what1");

                entity.Property(e => e.What2).HasColumnName("what2");

                entity.Property(e => e.Why1).HasColumnName("why1");

                entity.Property(e => e.Why2).HasColumnName("why2");

                entity.Property(e => e.Why3).HasColumnName("why3");

                entity.Property(e => e.Why4).HasColumnName("why4");

                entity.Property(e => e.Why5).HasColumnName("why5");

                entity.HasOne(d => d.Category1Navigation)
                    .WithMany(p => p.KaizenItems)
                    .HasForeignKey(d => d.Category1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KaizenItems_KaizenTopCat");

                entity.HasOne(d => d.Category2Navigation)
                    .WithMany(p => p.KaizenItems)
                    .HasForeignKey(d => d.Category2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KaizenItems_KaizenSecondCat");

                entity.HasOne(d => d.KaizenItemParent)
                    .WithMany(p => p.InverseKaizenItemParent)
                    .HasForeignKey(d => d.KaizenItemParentId)
                    .HasConstraintName("FK_KaizenItems_KaizenItems");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.KaizenItems)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KaizenItems_Users");
            });

            modelBuilder.Entity<KaizenSecondCat>(entity =>
            {
                entity.ToTable("KaizenSecondCat");

                entity.Property(e => e.KaizenSecondCatId).HasColumnName("KaizenSecondCatID");
            });

            modelBuilder.Entity<KaizenTopCat>(entity =>
            {
                entity.ToTable("KaizenTopCat");

                entity.Property(e => e.KaizenTopCatId).HasColumnName("KaizenTopCatID");
            });

            modelBuilder.Entity<KaizenUserScoreAttempt>(entity =>
            {
                entity.HasKey(e => e.KaizenScoreAttempts)
                    .HasName("PK__KaizenUs__C7927EDCE9380CEF");

                entity.Property(e => e.KaizenId).HasColumnName("KaizenID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VoteTypeId).HasColumnName("VoteTypeID");

                entity.HasOne(d => d.Kaizen)
                    .WithMany(p => p.KaizenUserScoreAttempts)
                    .HasForeignKey(d => d.KaizenId)
                    .HasConstraintName("FK_KaizenUserScoreAttempts_Kaizen");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.KaizenUserScoreAttempts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_KaizenUserScoreAttempts_Users");
            });

            modelBuilder.Entity<KaizenVoteScore>(entity =>
            {
                entity.ToTable("KaizenVoteScore");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KaizenItemId).HasColumnName("kaizenItemId");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.UserIdVoted).HasColumnName("userIdVoted");

                entity.Property(e => e.UserIdVoting).HasColumnName("userIdVoting");

                entity.Property(e => e.Vote).HasColumnName("vote");

                entity.HasOne(d => d.KaizenItem)
                    .WithMany(p => p.KaizenVoteScores)
                    .HasForeignKey(d => d.KaizenItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KaizenVoteScore_KaizenItems");

                entity.HasOne(d => d.UserIdVotedNavigation)
                    .WithMany(p => p.KaizenVoteScoreUserIdVotedNavigations)
                    .HasForeignKey(d => d.UserIdVoted)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KaizenVoteScore_Users1");

                entity.HasOne(d => d.UserIdVotingNavigation)
                    .WithMany(p => p.KaizenVoteScoreUserIdVotingNavigations)
                    .HasForeignKey(d => d.UserIdVoting)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KaizenVoteScore_Users");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LogID");

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RequestURL");

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MultiUserReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Users)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.GeneratedByNavigation)
                    .WithMany(p => p.MultiUserReports)
                    .HasForeignKey(d => d.GeneratedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MultiUserReports_Users");
            });

            modelBuilder.Entity<NotificationGlobalSubscription>(entity =>
            {
                entity.HasKey(e => e.NotificationGlobalSuscriptionId)
                    .HasName("PK__Notifica__97BF713EB7F63932");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.NotificationGlobalSubscriptions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Notificat__Clien__038683F8");

                entity.HasOne(d => d.NotificationItem)
                    .WithMany(p => p.NotificationGlobalSubscriptions)
                    .HasForeignKey(d => d.NotificationItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Notificat__Notif__02925FBF");
            });

            modelBuilder.Entity<NotificationItem>(entity =>
            {
                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultDevices)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NotificationKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notificationKey");

                entity.Property(e => e.Tooltip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tooltip");
            });

            modelBuilder.Entity<NotificationLog>(entity =>
            {
                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.NotificationItem)
                    .WithMany(p => p.NotificationLogs)
                    .HasForeignKey(d => d.NotificationItemId)
                    .HasConstraintName("FK_NotificationLogs_NotificationItems");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationLogs_Users");
            });

            modelBuilder.Entity<NotificationLogDevice>(entity =>
            {
                entity.Property(e => e.DentDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.NotificationLog)
                    .WithMany(p => p.NotificationLogDevices)
                    .HasForeignKey(d => d.NotificationLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationLogDevices_NotificationLogs");
            });

            modelBuilder.Entity<NotificationMaster>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK__Notifica__20CF2E32AAA8CCE8");

                entity.ToTable("NotificationMaster");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.ActionItemId).HasColumnName("ActionItemID");

                entity.Property(e => e.NotificationAcceptanceDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NotificationFromUserId).HasColumnName("NotificationFromUserID");

                entity.Property(e => e.NotificationRegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationStartDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationToUserId).HasColumnName("NotificationToUserID");

                entity.HasOne(d => d.ActionItem)
                    .WithMany(p => p.NotificationMasters)
                    .HasForeignKey(d => d.ActionItemId)
                    .HasConstraintName("FK_NotificationMaster_ActionList");

                entity.HasOne(d => d.NotificationFromUser)
                    .WithMany(p => p.NotificationMasterNotificationFromUsers)
                    .HasForeignKey(d => d.NotificationFromUserId)
                    .HasConstraintName("FK_NotificationMaster_FromUser");

                entity.HasOne(d => d.NotificationToUser)
                    .WithMany(p => p.NotificationMasterNotificationToUsers)
                    .HasForeignKey(d => d.NotificationToUserId)
                    .HasConstraintName("FK_NotificationMaster_ToUser");
            });

            modelBuilder.Entity<NotificationSuscription>(entity =>
            {
                entity.HasOne(d => d.NotificationItem)
                    .WithMany(p => p.NotificationSuscriptions)
                    .HasForeignKey(d => d.NotificationItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationSuscriptions_NotificationItems");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NotificationSuscriptions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationSuscriptions_Users");
            });

            modelBuilder.Entity<OrganizationHierarchy>(entity =>
            {
                entity.HasKey(e => e.RelationshipId)
                    .HasName("PK__Organiza__31FEB861A3BE2B09");

                entity.ToTable("OrganizationHierarchy");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ManagerUserId).HasColumnName("ManagerUserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrganizationHierarchies)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_OrganizationHierarchy_Clients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.OrganizationHierarchyEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_OrganizationHierarchy_Employees");

                entity.HasOne(d => d.ManagerUser)
                    .WithMany(p => p.OrganizationHierarchyManagerUsers)
                    .HasForeignKey(d => d.ManagerUserId)
                    .HasConstraintName("FK_OrganizationHierarchy_Managers");
            });

            modelBuilder.Entity<PasswordChangeRequest>(entity =>
            {
                entity.ToTable("PasswordChangeRequest");

                entity.Property(e => e.PasswordChangeRequestId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PasswordChangeRequestID");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("section");
            });

            modelBuilder.Entity<Playbook>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_playbook");

                entity.ToTable("Playbook");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_playbook_playbook");
            });

            modelBuilder.Entity<PlaybookDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentBoxId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.PlaybookCategoryId).HasColumnName("PlaybookCategoryID");

                entity.HasOne(d => d.PlaybookCategory)
                    .WithMany(p => p.PlaybookDocuments)
                    .HasForeignKey(d => d.PlaybookCategoryId)
                    .HasConstraintName("FK_PlaybookDocuments_Playbook");
            });

            modelBuilder.Entity<PlaybookFavorite>(entity =>
            {
                entity.HasKey(e => e.FavoriteId);

                entity.HasOne(d => d.PlaybookDocument)
                    .WithMany(p => p.PlaybookFavorites)
                    .HasForeignKey(d => d.PlaybookDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaybookFavorites_PlaybookDocuments");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PlaybookFavorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaybookFavorites_Users");
            });

            modelBuilder.Entity<PlaybookLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PK__Playbook__2D122135D6D9861C");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PlaybookDocumentId).HasColumnName("PlaybookDocumentID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.HasOne(d => d.PlaybookDocument)
                    .WithMany(p => p.PlaybookLinks)
                    .HasForeignKey(d => d.PlaybookDocumentId)
                    .HasConstraintName("FK_PlaybookLinks_ToPlaybookDocuments");
            });

            modelBuilder.Entity<PlaybookMaster>(entity =>
            {
                entity.HasKey(e => e.PlaybookId)
                    .HasName("PK__Playbook__89CFA26A9CFE8AB7");

                entity.ToTable("PlaybookMaster");

                entity.Property(e => e.PlaybookId).HasColumnName("PlaybookID");
            });

            modelBuilder.Entity<PlaybookNew>(entity =>
            {
                entity.HasKey(e => e.PlaybookId);

                entity.ToTable("PlaybookNew");

                entity.Property(e => e.PlaybookId).HasColumnName("PlaybookID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcessJob>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailOwner)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastRun).HasColumnName("lastRun");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Namespace)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessesMaster>(entity =>
            {
                entity.HasKey(e => e.ProcessId)
                    .HasName("PK__Processe__1B39A976AA8FCA58");

                entity.ToTable("ProcessesMaster");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProcessName).HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcessesMasters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProcessesMaster_Users");
            });

            modelBuilder.Entity<ProcessesStep>(entity =>
            {
                entity.HasKey(e => e.ProcessStepId)
                    .HasName("PK__Processe__7EA45C4D688C2885");

                entity.Property(e => e.ProcessStepId).HasColumnName("ProcessStepID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProcessStepName).HasMaxLength(250);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.ProcessesSteps)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_ProcessesSteps_ProcessesMaster");
            });

            modelBuilder.Entity<ProductUpdate>(entity =>
            {
                entity.Property(e => e.ProductUpdateId).HasColumnName("ProductUpdateID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.PreviousProductUpdateId).HasColumnName("PreviousProductUpdateID");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Version).HasMaxLength(30);

                entity.HasOne(d => d.PreviousProductUpdate)
                    .WithMany(p => p.InversePreviousProductUpdate)
                    .HasForeignKey(d => d.PreviousProductUpdateId)
                    .HasConstraintName("FK__ProductUp__Activ__74444068");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.IsActive).IsRequired();
            });

            modelBuilder.Entity<ProviderStorageAccountType>(entity =>
            {
                entity.ToTable("ProviderStorageAccountType");

                entity.Property(e => e.ProviderStorageAccountTypeId).HasColumnName("ProviderStorageAccountTypeID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.ProviderStorageAccountTypes)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderStorageAccountType_StorageAccountTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProviderStorageAccountTypes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProviderStorageAccountType_Users");
            });

            modelBuilder.Entity<ReportDocLog>(entity =>
            {
                entity.HasKey(e => e.ReportDocId);

                entity.Property(e => e.ReportDocId).HasColumnName("ReportDocID");

                entity.Property(e => e.ReportDocDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReportDocFullPath).IsRequired();

                entity.Property(e => e.ReportDocName).IsRequired();

                entity.HasOne(d => d.ReportDocBelongsToNavigation)
                    .WithMany(p => p.ReportDocLogReportDocBelongsToNavigations)
                    .HasForeignKey(d => d.ReportDocBelongsTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDocLogs_ReportDocBelongsTo");

                entity.HasOne(d => d.ReportDocGeneratedByNavigation)
                    .WithMany(p => p.ReportDocLogReportDocGeneratedByNavigations)
                    .HasForeignKey(d => d.ReportDocGeneratedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDocLogs_GeneratedBy");
            });

            modelBuilder.Entity<ReportTemplate>(entity =>
            {
                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

                entity.Property(e => e.Archive)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DocumentName).HasMaxLength(1000);

                entity.Property(e => e.TemplateKey).HasMaxLength(50);

                entity.Property(e => e.UserTitleId).HasColumnName("UserTitleID");

                entity.HasOne(d => d.UserTitle)
                    .WithMany(p => p.ReportTemplates)
                    .HasForeignKey(d => d.UserTitleId)
                    .HasConstraintName("FK_ReportTemplates_UserTitles");
            });

            modelBuilder.Entity<ReportTemplateAssignment>(entity =>
            {
                entity.Property(e => e.ReportTemplateAssignmentId).HasColumnName("ReportTemplateAssignmentID");

                entity.Property(e => e.Archived)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.AssignmentDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

                entity.Property(e => e.StatusLastUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.AssignedByNavigation)
                    .WithMany(p => p.ReportTemplateAssignments)
                    .HasForeignKey(d => d.AssignedBy)
                    .HasConstraintName("FK_ReportTemplateAssignments_Users");

                entity.HasOne(d => d.ReportTemplate)
                    .WithMany(p => p.ReportTemplateAssignments)
                    .HasForeignKey(d => d.ReportTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateAssignments_ReportTemplates");
            });

            modelBuilder.Entity<ReportTemplateAssignmentAssignee>(entity =>
            {
                entity.Property(e => e.ReportTemplateAssignmentAssigneeId).HasColumnName("ReportTemplateAssignmentAssigneeID");

                entity.Property(e => e.ReportTemplateAssignmentId).HasColumnName("ReportTemplateAssignmentID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ReportTemplateAssignment)
                    .WithMany(p => p.ReportTemplateAssignmentAssignees)
                    .HasForeignKey(d => d.ReportTemplateAssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateAssignmentAssignees_ReportTemplateAssignments");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportTemplateAssignmentAssignees)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateAssignmentAssignees_Users");
            });

            modelBuilder.Entity<ReportTemplateFavorite>(entity =>
            {
                entity.Property(e => e.ReportTemplateFavoriteId).HasColumnName("ReportTemplateFavoriteID");

                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ReportTemplate)
                    .WithMany(p => p.ReportTemplateFavorites)
                    .HasForeignKey(d => d.ReportTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateFavorites_ReportTemplateID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportTemplateFavorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateFavorites_UserID");
            });

            modelBuilder.Entity<ReportTemplateLog>(entity =>
            {
                entity.Property(e => e.ReportTemplateLogId).HasColumnName("ReportTemplateLogID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ReportTemplate)
                    .WithMany(p => p.ReportTemplateLogs)
                    .HasForeignKey(d => d.ReportTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateLogs_ReportTemplateID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportTemplateLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateLogs_UserID");
            });

            modelBuilder.Entity<ReportTemplateSection>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateReportId).HasColumnName("TemplateReportID");

                entity.HasOne(d => d.TemplateReport)
                    .WithMany(p => p.ReportTemplateSections)
                    .HasForeignKey(d => d.TemplateReportId)
                    .HasConstraintName("FK_dbo.ReportTemplateSections_dbo.ReportTemplates");
            });

            modelBuilder.Entity<ResetAudit>(entity =>
            {
                entity.Property(e => e.ResetAuditId).HasColumnName("ResetAuditID");

                entity.Property(e => e.ResetEndTime).HasColumnType("datetime");

                entity.Property(e => e.ResetStartTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ResetAudits)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ResetAudits_Users");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.DepartmentBranchId).HasColumnName("DepartmentBranchID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ResourceAvailabityStatusId).HasColumnName("ResourceAvailabityStatusID");

                entity.Property(e => e.ResourceName).HasMaxLength(500);

                entity.HasOne(d => d.DepartmentBranch)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.DepartmentBranchId)
                    .HasConstraintName("FK_Resources_DepartmentBranches");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Resources_Departments");

                entity.HasOne(d => d.ResourceAvailabityStatus)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.ResourceAvailabityStatusId)
                    .HasConstraintName("FK_Resources_ResourceAvailStatuses");
            });

            modelBuilder.Entity<ResourceAvailStatus>(entity =>
            {
                entity.HasKey(e => e.ResourceAvailabityStatusId)
                    .HasName("PK__Resource__59CA979F684404F3");

                entity.Property(e => e.ResourceAvailabityStatusId).HasColumnName("ResourceAvailabityStatusID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleDescription).HasMaxLength(200);
            });

            modelBuilder.Entity<ScheduleItem>(entity =>
            {
                entity.Property(e => e.ScheduleItemId).HasColumnName("ScheduleItemID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.SchedlueItemTo).HasColumnType("datetime");

                entity.Property(e => e.ScheduleItemFrom).HasColumnType("datetime");

                entity.Property(e => e.ScheduleItemName).HasMaxLength(500);

                entity.Property(e => e.ScheduledByUserId).HasColumnName("ScheduledByUserID");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ScheduleItems)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_ScheduleItems_Resources");

                entity.HasOne(d => d.ScheduledByUser)
                    .WithMany(p => p.ScheduleItemScheduledByUsers)
                    .HasForeignKey(d => d.ScheduledByUserId)
                    .HasConstraintName("FK_ScheduleItems_Users");

                entity.HasOne(d => d.ScheduledUserNavigation)
                    .WithMany(p => p.ScheduleItemScheduledUserNavigations)
                    .HasForeignKey(d => d.ScheduledUser)
                    .HasConstraintName("FK_ScheduleItems_ScheduledUser");
            });

            modelBuilder.Entity<ScheduleItemsDetail>(entity =>
            {
                entity.HasKey(e => e.ScheduleItemDetailId)
                    .HasName("PK__Schedule__98D865CB75213C5D");

                entity.Property(e => e.ScheduleItemDetailId).HasColumnName("ScheduleItemDetailID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.ScheduleItemType).HasMaxLength(50);

                entity.Property(e => e.ScheduleStartFrom).HasColumnType("datetime");

                entity.Property(e => e.ScheduleStartTo).HasColumnType("datetime");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleItemsDetails)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_ScheduleItemsDetails_ScheduleItems");
            });

            modelBuilder.Entity<SecretQuestion>(entity =>
            {
                entity.Property(e => e.SecretQuestionId).HasColumnName("SecretQuestionID");

                entity.Property(e => e.SecretQuestion1)
                    .HasMaxLength(500)
                    .HasColumnName("SecretQuestion");
            });

            modelBuilder.Entity<SiteLink>(entity =>
            {
                entity.HasKey(e => e.NavId)
                    .HasName("PK__SiteLink__67283A734A725783");

                entity.Property(e => e.NavId).HasColumnName("NavID");

                entity.Property(e => e.Beta)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.NavImage).HasMaxLength(50);

                entity.Property(e => e.NavSection)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NavTitle).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SiteNavigation>(entity =>
            {
                entity.HasKey(e => e.NavId)
                    .HasName("PK__SiteNavi__67283A733A09E67C");

                entity.Property(e => e.NavId)
                    .ValueGeneratedNever()
                    .HasColumnName("NavID");

                entity.Property(e => e.NavImage).HasMaxLength(50);

                entity.Property(e => e.NavSection).HasMaxLength(30);

                entity.Property(e => e.NavTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<SqueezeAggregate>(entity =>
            {
                entity.HasKey(e => e.SqueezeId);

                entity.ToTable("SqueezeAggregate");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SqueezeAggregates)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SqueezeAggregate_Users");
            });

            modelBuilder.Entity<StorageAccountType>(entity =>
            {
                entity.HasKey(e => e.AccountTypeId);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.AccountName).IsRequired();

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.StorageAccountTypes)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_dbo.ProviderID_dbo.StorageAccountTypes");
            });

            modelBuilder.Entity<TaskOwnerLookup>(entity =>
            {
                entity.HasKey(e => e.TaskOwnerId)
                    .HasName("PK__TaskOwne__29071C56FD440FDB");

                entity.ToTable("TaskOwnerLookup");

                entity.Property(e => e.TaskOwnerId).HasColumnName("TaskOwnerID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TaskReportTemplate>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DueDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Roles).HasMaxLength(1000);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.TaskDocRef).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TemplateKey).HasMaxLength(50);

                entity.Property(e => e.TemplateTaskId).HasColumnName("TemplateTaskID");

                entity.Property(e => e.TimeUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.TaskReportTemplates)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ReportTemplateSections_dbo.ReportTemplateSections");

                entity.HasOne(d => d.TemplateTask)
                    .WithMany(p => p.TaskReportTemplates)
                    .HasForeignKey(d => d.TemplateTaskId)
                    .HasConstraintName("FK_dbo.TaskReportTemplates_dbo.TemplateTaskNew");
            });

            modelBuilder.Entity<TaskStatus>(entity =>
            {
                entity.Property(e => e.TaskStatusId).HasColumnName("TaskStatusID");

                entity.Property(e => e.TaskStatusDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<TaskType>(entity =>
            {
                entity.ToTable("TaskType");

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.TaskTypeDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Archive).HasColumnName("archive");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teams_Clients");

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.Manager)
                    .HasConstraintName("FK_Teams_Users");
            });

            modelBuilder.Entity<TeamFavorite>(entity =>
            {
                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamFavorites)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamFavorites_Teams");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeamFavorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamFavorites_Users");
            });

            modelBuilder.Entity<TeamMember>(entity =>
            {
                entity.Property(e => e.PositionDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Boss)
                    .WithMany(p => p.InverseBoss)
                    .HasForeignKey(d => d.BossId)
                    .HasConstraintName("FK_TeamMembers_TeamMembers");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamMembers_Teams");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeamMembers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamMembers_Users");
            });

            modelBuilder.Entity<TemplateTaskCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("TemplateTaskCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Archived)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.CategoryTypeId).HasColumnName("CategoryTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.CategoryType)
                    .WithMany(p => p.TemplateTaskCategories)
                    .HasForeignKey(d => d.CategoryTypeId)
                    .HasConstraintName("FK_TemplateTaskCategory_TemplateTaskCategoryType");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TemplateTaskCategories)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_TemplateTaskCategory_Clients");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_TemplateTaskCategory_TemplateTaskCategory");
            });

            modelBuilder.Entity<TemplateTaskCategoryType>(entity =>
            {
                entity.HasKey(e => e.CategoryTypeId);

                entity.ToTable("TemplateTaskCategoryType");

                entity.Property(e => e.CategoryTypeId).HasColumnName("CategoryTypeID");

                entity.Property(e => e.CategoryTypeName).HasMaxLength(1000);
            });

            modelBuilder.Entity<TemplateTaskNew>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("TemplateTaskNew");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.Archive)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.Assignable)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TaskCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TemplateTaskNews)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_TemplateTaskNew_Clients");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.TemplateTaskNewCreatorNavigations)
                    .HasForeignKey(d => d.Creator)
                    .HasConstraintName("FK_TemplateTaskNew_UserCreator");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_TemplateTaskNew_ActionItems");

                entity.HasOne(d => d.TaskCategoryNavigation)
                    .WithMany(p => p.TemplateTaskNewTaskCategoryNavigations)
                    .HasForeignKey(d => d.TaskCategory)
                    .HasConstraintName("FK_TemplateTaskNew_TemplateTaskCategory");

                entity.HasOne(d => d.TaskSubCategoryNavigation)
                    .WithMany(p => p.TemplateTaskNewTaskSubCategoryNavigations)
                    .HasForeignKey(d => d.TaskSubCategory)
                    .HasConstraintName("FK_TemplateTaskNew_TemplateTaskSubCategory");

                entity.HasOne(d => d.TemplateApproverNavigation)
                    .WithMany(p => p.TemplateTaskNewTemplateApproverNavigations)
                    .HasForeignKey(d => d.TemplateApprover)
                    .HasConstraintName("FK_TemplateTaskNew_Users");
            });

            modelBuilder.Entity<TemplateTaskNewFavorite>(entity =>
            {
                entity.HasOne(d => d.TemplateTaskNew)
                    .WithMany(p => p.TemplateTaskNewFavorites)
                    .HasForeignKey(d => d.TemplateTaskNewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorite_TemplateTaskId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TemplateTaskNewFavorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoriteTemplateTask_Users");
            });

            modelBuilder.Entity<TemplateTaskPlaybookDocument>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.DocumentId })
                    .HasName("PK__Template__9DC2A7272BE55DB0");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.TemplateTaskPlaybookDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TemplateT__Docum__7814D14C");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TemplateTaskPlaybookDocuments)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TemplateT__TaskI__7720AD13");
            });

            modelBuilder.Entity<TemplateTaskResource>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceUrl).HasColumnName("ResourceURL");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TemplateTaskResources)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TemplateTaskResources_TemplateTaskNew");
            });

            modelBuilder.Entity<Tip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tip");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreationDate)
                    .HasMaxLength(500)
                    .HasColumnName("creationDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.PreviousTipId)
                    .HasMaxLength(500)
                    .HasColumnName("previousTipID");

                entity.Property(e => e.TipId).HasColumnName("tipID");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AcceptedTermsOfUse)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.Address1).HasMaxLength(500);

                entity.Property(e => e.Address2).HasMaxLength(500);

                entity.Property(e => e.AvailablityId).HasColumnName("AvailablityID");

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.EmpStartDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(500);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(500);

                entity.Property(e => e.LastPasswordUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.ProfilePicUrl)
                    .HasMaxLength(100)
                    .HasColumnName("ProfilePicURL");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.TitleId).HasColumnName("TitleID");

                entity.Property(e => e.UserTitleId).HasColumnName("UserTitleID");

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.Property(e => e.Zip).HasMaxLength(200);

                entity.HasOne(d => d.Availablity)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AvailablityId)
                    .HasConstraintName("FK_Users_UserAvailableStatus");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Users_Clients");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Users_Departments");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Users_Roles");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_Users_USStates");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK_Users_ClientTitles");

                entity.HasOne(d => d.UserTitle)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTitleId)
                    .HasConstraintName("FK_Users_UsersTitles");
            });

            modelBuilder.Entity<UserAvailableStatus>(entity =>
            {
                entity.HasKey(e => e.AvailabilityId)
                    .HasName("PK__UserAvai__DA3979916C22BC5E");

                entity.ToTable("UserAvailableStatus");

                entity.Property(e => e.AvailabilityId).HasColumnName("AvailabilityID");

                entity.Property(e => e.AvailabilityDescription).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ColorCode).HasMaxLength(50);
            });

            modelBuilder.Entity<UserConfiguration>(entity =>
            {
                entity.Property(e => e.UserConfigurationId).HasColumnName("UserConfigurationID");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.HasOne(d => d.BelongsToUserNavigation)
                    .WithMany(p => p.UserConfigurations)
                    .HasForeignKey(d => d.BelongsToUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserConfigurations_Users");
            });

            modelBuilder.Entity<UserDocumentPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.ProviderDocumentId)
                    .IsRequired()
                    .HasColumnName("ProviderDocumentID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserStorageAccountId).HasColumnName("UserStorageAccountID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDocumentPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Users_dbo.UserDocumentPermissions");

                entity.HasOne(d => d.UserStorageAccount)
                    .WithMany(p => p.UserDocumentPermissions)
                    .HasForeignKey(d => d.UserStorageAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDocumentPermissions_UserStorageAccountTypes");
            });

            modelBuilder.Entity<UserMessaging>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__UserMess__C87C037CD589ED20");

                entity.ToTable("UserMessaging");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.FromUserId).HasColumnName("FromUserID");

                entity.Property(e => e.MessageTimestamp).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.UserMessagingFromUsers)
                    .HasForeignKey(d => d.FromUserId)
                    .HasConstraintName("FK_UserMessaging_UsersFrom");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.UserMessagingToUsers)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK_UserMessaging_UsersTo");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.UserId });

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermissions_Permissions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermissions_Users1");
            });

            modelBuilder.Entity<UserProfileChangeTrace>(entity =>
            {
                entity.HasKey(e => e.TraceRowId);

                entity.Property(e => e.TraceRowId).HasColumnName("TraceRowID");

                entity.Property(e => e.TraceId).HasColumnName("TraceID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProfileChangeTraces)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserProfileChangeTraces_Users");
            });

            modelBuilder.Entity<UserSecretAnswer>(entity =>
            {
                entity.Property(e => e.UserSecretAnswerId).HasColumnName("UserSecretAnswerID");

                entity.Property(e => e.SecretAnswer).HasMaxLength(500);

                entity.Property(e => e.SecretQuestionId).HasColumnName("SecretQuestionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.SecretQuestion)
                    .WithMany(p => p.UserSecretAnswers)
                    .HasForeignKey(d => d.SecretQuestionId)
                    .HasConstraintName("FK_UserSecretAnswers_SecretQuestions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSecretAnswers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserSecretAnswers_UserID");
            });

            modelBuilder.Entity<UserSqueeze>(entity =>
            {
                entity.HasKey(e => e.SqueezeId);

                entity.ToTable("UserSqueeze");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserSqueezes)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_UserSqueeze_UserTasks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSqueezes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSqueeze_Users");
            });

            modelBuilder.Entity<UserStorageAccountType>(entity =>
            {
                entity.HasKey(e => e.UserStorageAccountId);

                entity.Property(e => e.UserStorageAccountId).HasColumnName("UserStorageAccountID");

                entity.Property(e => e.AccessToken).IsRequired();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.LastRefresh).HasColumnType("datetime");

                entity.Property(e => e.ProviderTempFolderId)
                    .IsRequired()
                    .HasColumnName("ProviderTempFolderID");

                entity.Property(e => e.RefreshToken).IsRequired();

                entity.Property(e => e.StorageAccountTypeId).HasColumnName("StorageAccountTypeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserStorageAccountTypes)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_dbo.ClientID_dbo.UserStorageAccountTypes");

                entity.HasOne(d => d.StorageAccountType)
                    .WithMany(p => p.UserStorageAccountTypes)
                    .HasForeignKey(d => d.StorageAccountTypeId)
                    .HasConstraintName("FK_dbo.StorageAccountTypeID_dbo.UserStorageAccountTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserStorageAccountTypes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Clients_dbo.UserStorageAccountTypes");
            });

            modelBuilder.Entity<UserTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK__UserTask__7C6949D116DC2CD3");

                entity.HasIndex(e => e.BelongsToUser, "NonClusteredIndex-20150418-172847");

                entity.HasIndex(e => e.ParentId, "NonClusteredIndex-20150418-173029");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.ApprovalDate).HasColumnType("date");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RecurrenceId).HasColumnName("RecurrenceID");

                entity.Property(e => e.TaskAssignedDate).HasColumnType("date");

                entity.Property(e => e.TaskCompletedDate).HasColumnType("date");

                entity.Property(e => e.TaskEndDate).HasColumnType("date");

                entity.Property(e => e.TaskGroupId).HasColumnName("TaskGroupID");

                entity.Property(e => e.TaskName).HasMaxLength(250);

                entity.Property(e => e.TaskStatusId).HasColumnName("TaskStatusID");

                entity.Property(e => e.TaskSubGroupId).HasColumnName("TaskSubGroupID");

                entity.Property(e => e.TemplateTaskId).HasColumnName("TemplateTaskID");

                entity.HasOne(d => d.ApproverNavigation)
                    .WithMany(p => p.UserTaskApproverNavigations)
                    .HasForeignKey(d => d.Approver)
                    .HasConstraintName("FK_UserTasks_Approver");

                entity.HasOne(d => d.BelongsToUserNavigation)
                    .WithMany(p => p.UserTaskBelongsToUserNavigations)
                    .HasForeignKey(d => d.BelongsToUser)
                    .HasConstraintName("FK_UserTasks_Users");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.UserTasks_dbo.UserTasks_ParentID");

                entity.HasOne(d => d.TaskAssignedByNavigation)
                    .WithMany(p => p.UserTaskTaskAssignedByNavigations)
                    .HasForeignKey(d => d.TaskAssignedBy)
                    .HasConstraintName("FK_UserTasks_AssigneeUser");

                entity.HasOne(d => d.TaskCreatedByNavigation)
                    .WithMany(p => p.UserTaskTaskCreatedByNavigations)
                    .HasForeignKey(d => d.TaskCreatedBy)
                    .HasConstraintName("FK_UserTasks_TaskCreatedBy");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.UserTaskTaskGroups)
                    .HasForeignKey(d => d.TaskGroupId)
                    .HasConstraintName("FK_UserTasks_TemplateTaskCategory");

                entity.HasOne(d => d.TaskStatus)
                    .WithMany(p => p.UserTasks)
                    .HasForeignKey(d => d.TaskStatusId)
                    .HasConstraintName("FK_UserTasks_TaskStatus");

                entity.HasOne(d => d.TaskSubGroup)
                    .WithMany(p => p.UserTaskTaskSubGroups)
                    .HasForeignKey(d => d.TaskSubGroupId)
                    .HasConstraintName("FK_UserTasks_TemplateTaskSubCategory");

                entity.HasOne(d => d.TaskTypeNavigation)
                    .WithMany(p => p.UserTasks)
                    .HasForeignKey(d => d.TaskType)
                    .HasConstraintName("FK_UserTasks_TaskType");

                entity.HasOne(d => d.TemplateTask)
                    .WithMany(p => p.UserTasks)
                    .HasForeignKey(d => d.TemplateTaskId)
                    .HasConstraintName("FK_UserTasks_TemplateTaskNew");
            });

            modelBuilder.Entity<UserTaskAdditionalOwner>(entity =>
            {
                entity.HasKey(e => e.AdditionalOwnerId)
                    .HasName("PK__UserTask__FD7C76DFCFBDFD8F");

                entity.Property(e => e.AdditionalOwnerId).HasColumnName("AdditionalOwnerID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskOwnerLookupId).HasColumnName("TaskOwnerLookupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskAdditionalOwners)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserTaskAdditionalOwners_UserTasks");

                entity.HasOne(d => d.TaskOwnerLookup)
                    .WithMany(p => p.UserTaskAdditionalOwners)
                    .HasForeignKey(d => d.TaskOwnerLookupId)
                    .HasConstraintName("FK_UserTaskAdditionalOwners_TaskOwnerLookup");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTaskAdditionalOwners)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserTaskAdditionalOwners_UserID");
            });

            modelBuilder.Entity<UserTaskApprovalRequeriment>(entity =>
            {
                entity.HasKey(e => e.ApprovalRequerimentId)
                    .HasName("PK__UserTaskApprovalRequeriments__1CBEEF6FAF23ED4B");

                entity.Property(e => e.ApprovalRequerimentId).HasColumnName("ApprovalRequerimentID");

                entity.Property(e => e.BoxDocumentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BoxDocumentID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName).HasMaxLength(100);

                entity.Property(e => e.DocumentPath).HasMaxLength(100);

                entity.Property(e => e.ProviderStorageAccountId).HasColumnName("ProviderStorageAccountID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskApprovalRequeriments)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_UserTaskApprovalRequeriments_UserTasks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTaskApprovalRequeriments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTaskApprovalRequeriments_Users");
            });

            modelBuilder.Entity<UserTaskComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__UserTask__C3B4DFAAEF8F4ED8");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.Moment).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TemplateTaskId).HasColumnName("TemplateTaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskComments)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_UserTaskComments_UserTasks1");

                entity.HasOne(d => d.TemplateTask)
                    .WithMany(p => p.UserTaskComments)
                    .HasForeignKey(d => d.TemplateTaskId)
                    .HasConstraintName("FK_UserTaskComments_TemplateTaskNews");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTaskComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTaskComments_Users");
            });

            modelBuilder.Entity<UserTaskDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("PK__UserTask__1ABEEF6FAF23ED4B");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.BoxDocumentId)
                    .IsRequired()
                    .HasColumnName("BoxDocumentID");

                entity.Property(e => e.DocumentName).IsRequired();

                entity.Property(e => e.DocumentPath).IsRequired();

                entity.Property(e => e.DocumentUploadedOn).HasColumnType("datetime");

                entity.Property(e => e.LastAccessedOn).HasColumnType("datetime");

                entity.Property(e => e.ProviderParentFolderId).HasMaxLength(50);

                entity.Property(e => e.ProviderStorageAccountId).HasColumnName("ProviderStorageAccountID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TempActionItemId).HasColumnName("TempActionItemID");

                entity.Property(e => e.TempTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TemplateTaskId).HasColumnName("TemplateTaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskDocuments)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("fk_UserTasks_UserTaskDocuments");

                entity.HasOne(d => d.TemplateTask)
                    .WithMany(p => p.UserTaskDocuments)
                    .HasForeignKey(d => d.TemplateTaskId)
                    .HasConstraintName("fk_TemplateTaskNew_UserTaskDocuments");
            });

            modelBuilder.Entity<UserTaskLastSeen>(entity =>
            {
                entity.ToTable("UserTaskLastSeen");

                entity.Property(e => e.UserTaskLastSeenId).HasColumnName("UserTaskLastSeenID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskLastSeens)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserTaskL__TaskI__7EC1CEDB");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTaskLastSeens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserTaskL__UserI__7FB5F314");
            });

            modelBuilder.Entity<UserTaskPlaybookDocument>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.DocumentId })
                    .HasName("PK__UserTask__9DC2A72721061748");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.UserTaskPlaybookDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserTaskP__Docum__7BE56230");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskPlaybookDocuments)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserTaskP__TaskI__7AF13DF7");
            });

            modelBuilder.Entity<UserTaskResource>(entity =>
            {
                entity.HasKey(e => e.ResourceId)
                    .HasName("PK__UserTask__4ED1814F8BD61B20");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskResources)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_UserTaskResources_UserTasks");
            });

            modelBuilder.Entity<UserTaskTracer>(entity =>
            {
                entity.HasKey(e => e.TraceId)
                    .HasName("PK__UserTaskTracer__7C6949D116DC2CD3");

                entity.ToTable("UserTaskTracer");

                entity.Property(e => e.TraceId).HasColumnName("TraceID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIdto).HasColumnName("UserIDTo");

                entity.HasOne(d => d.StatusFromNavigation)
                    .WithMany(p => p.UserTaskTracerStatusFromNavigations)
                    .HasForeignKey(d => d.StatusFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTaskTracer_StatusFrom");

                entity.HasOne(d => d.StatusToNavigation)
                    .WithMany(p => p.UserTaskTracerStatusToNavigations)
                    .HasForeignKey(d => d.StatusTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTaskTracer_StatusTo");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTaskTracers)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTaskTracer_UserTasks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTaskTracerUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTaskTracer_Users");

                entity.HasOne(d => d.UserIdtoNavigation)
                    .WithMany(p => p.UserTaskTracerUserIdtoNavigations)
                    .HasForeignKey(d => d.UserIdto)
                    .HasConstraintName("FK_UserTaskTracer_UsersTo");
            });

            modelBuilder.Entity<UserTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId)
                    .HasName("PK__UserTitl__757589E6B978920C");

                entity.Property(e => e.TitleId).HasColumnName("TitleID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.TitleDescription).HasMaxLength(500);

                entity.Property(e => e.TitleName).HasMaxLength(500);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserTitles)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_UserTitles_Clients");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UserTitles)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_UserTitles_Departments");
            });

            modelBuilder.Entity<UserTitlePermission>(entity =>
            {
                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserTitlePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTitlePermissions2_Permissions");

                entity.HasOne(d => d.UserTitle)
                    .WithMany(p => p.UserTitlePermissions)
                    .HasForeignKey(d => d.UserTitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTitlePermissions2_UserTitles");
            });

            modelBuilder.Entity<UsersManager>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK__UsersMan__FFEE7451DEF0E984");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.UsersManagerManagers)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersManagers_Users_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersManagerUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersManagers_Users");
            });

            modelBuilder.Entity<Usstate>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("USStates");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VoteType>(entity =>
            {
                entity.ToTable("VoteType");

                entity.Property(e => e.VoteTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("VoteTypeID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

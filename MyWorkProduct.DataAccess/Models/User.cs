using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public class User
    {
        /*public User()
        {
            CalendarEvents = new HashSet<CalendarEvent>();
            ClientUserRoles = new HashSet<ClientUserRole>();
            KaizenItems = new HashSet<KaizenItem>();
            KaizenUserScoreAttempts = new HashSet<KaizenUserScoreAttempt>();
            KaizenVoteScoreUserIdVotedNavigations = new HashSet<KaizenVoteScore>();
            KaizenVoteScoreUserIdVotingNavigations = new HashSet<KaizenVoteScore>();
            Kaizens = new HashSet<Kaizen>();
            MultiUserReports = new HashSet<MultiUserReport>();
            NotificationLogs = new HashSet<NotificationLog>();
            NotificationMasterNotificationFromUsers = new HashSet<NotificationMaster>();
            NotificationMasterNotificationToUsers = new HashSet<NotificationMaster>();
            NotificationSuscriptions = new HashSet<NotificationSuscription>();
            OrganizationHierarchyEmployees = new HashSet<OrganizationHierarchy>();
            OrganizationHierarchyManagerUsers = new HashSet<OrganizationHierarchy>();
            PlaybookFavorites = new HashSet<PlaybookFavorite>();
            ProcessesMasters = new HashSet<ProcessesMaster>();
            ProviderStorageAccountTypes = new HashSet<ProviderStorageAccountType>();
            ReportDocLogReportDocBelongsToNavigations = new HashSet<ReportDocLog>();
            ReportDocLogReportDocGeneratedByNavigations = new HashSet<ReportDocLog>();
            ReportTemplateAssignmentAssignees = new HashSet<ReportTemplateAssignmentAssignee>();
            ReportTemplateAssignments = new HashSet<ReportTemplateAssignment>();
            ReportTemplateFavorites = new HashSet<ReportTemplateFavorite>();
            ReportTemplateLogs = new HashSet<ReportTemplateLog>();
            ResetAudits = new HashSet<ResetAudit>();
            ScheduleItemScheduledByUsers = new HashSet<ScheduleItem>();
            ScheduleItemScheduledUserNavigations = new HashSet<ScheduleItem>();
            SqueezeAggregates = new HashSet<SqueezeAggregate>();
            TeamFavorites = new HashSet<TeamFavorite>();
            TeamMembers = new HashSet<TeamMember>();
            Teams = new HashSet<Team>();
            TemplateTaskNewCreatorNavigations = new HashSet<TemplateTaskNew>();
            TemplateTaskNewFavorites = new HashSet<TemplateTaskNewFavorite>();
            TemplateTaskNewTemplateApproverNavigations = new HashSet<TemplateTaskNew>();
            UserConfigurations = new HashSet<UserConfiguration>();
            UserDocumentPermissions = new HashSet<UserDocumentPermission>();
            UserMessagingFromUsers = new HashSet<UserMessaging>();
            UserMessagingToUsers = new HashSet<UserMessaging>();
            UserPermissions = new HashSet<UserPermission>();
            UserProfileChangeTraces = new HashSet<UserProfileChangeTrace>();
            UserSecretAnswers = new HashSet<UserSecretAnswer>();
            UserSqueezes = new HashSet<UserSqueeze>();
            UserStorageAccountTypes = new HashSet<UserStorageAccountType>();
            UserTaskAdditionalOwners = new HashSet<UserTaskAdditionalOwner>();
            UserTaskApprovalRequeriments = new HashSet<UserTaskApprovalRequeriment>();
            UserTaskApproverNavigations = new HashSet<UserTask>();
            UserTaskBelongsToUserNavigations = new HashSet<UserTask>();
            UserTaskComments = new HashSet<UserTaskComment>();
            UserTaskLastSeens = new HashSet<UserTaskLastSeen>();
            UserTaskTaskAssignedByNavigations = new HashSet<UserTask>();
            UserTaskTaskCreatedByNavigations = new HashSet<UserTask>();
            UserTaskTracerUserIdtoNavigations = new HashSet<UserTaskTracer>();
            UserTaskTracerUsers = new HashSet<UserTaskTracer>();
            UsersManagerManagers = new HashSet<UsersManager>();
            UsersManagerUsers = new HashSet<UsersManager>();
        }*/

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public string Zip { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ProfilePicUrl { get; set; }
        public int? ClientId { get; set; }
        public DateTime? EmpStartDate { get; set; }
        public string Telephone { get; set; }
        public int? Country { get; set; }
        public int? AvailablityId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoleId { get; set; }
        public int? TitleId { get; set; }
        public int? UserTitleId { get; set; }
        public string Password1 { get; set; }
        public bool? AcceptedTermsOfUse { get; set; }
        public DateTime? LastPasswordUpdateDate { get; set; }
        public bool? ShowTips { get; set; }

        public virtual UserAvailableStatus Availablity { get; set; }
        public virtual Client Client { get; set; }
        public virtual Department Department { get; set; }
        public virtual Role Role { get; set; }
        public virtual Usstate State { get; set; }
        public virtual ClientTitle Title { get; set; }
        public virtual UserTitle UserTitle { get; set; }
        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; }
        public virtual ICollection<ClientUserRole> ClientUserRoles { get; set; }
        public virtual ICollection<KaizenItem> KaizenItems { get; set; }
        public virtual ICollection<KaizenUserScoreAttempt> KaizenUserScoreAttempts { get; set; }
        public virtual ICollection<KaizenVoteScore> KaizenVoteScoreUserIdVotedNavigations { get; set; }
        public virtual ICollection<KaizenVoteScore> KaizenVoteScoreUserIdVotingNavigations { get; set; }
        public virtual ICollection<Kaizen> Kaizens { get; set; }
        public virtual ICollection<MultiUserReport> MultiUserReports { get; set; }
        public virtual ICollection<NotificationLog> NotificationLogs { get; set; }
        public virtual ICollection<NotificationMaster> NotificationMasterNotificationFromUsers { get; set; }
        public virtual ICollection<NotificationMaster> NotificationMasterNotificationToUsers { get; set; }
        public virtual ICollection<NotificationSuscription> NotificationSuscriptions { get; set; }
        public virtual ICollection<OrganizationHierarchy> OrganizationHierarchyEmployees { get; set; }
        public virtual ICollection<OrganizationHierarchy> OrganizationHierarchyManagerUsers { get; set; }
        public virtual ICollection<PlaybookFavorite> PlaybookFavorites { get; set; }
        public virtual ICollection<ProcessesMaster> ProcessesMasters { get; set; }
        public virtual ICollection<ProviderStorageAccountType> ProviderStorageAccountTypes { get; set; }
        public virtual ICollection<ReportDocLog> ReportDocLogReportDocBelongsToNavigations { get; set; }
        public virtual ICollection<ReportDocLog> ReportDocLogReportDocGeneratedByNavigations { get; set; }
        public virtual ICollection<ReportTemplateAssignmentAssignee> ReportTemplateAssignmentAssignees { get; set; }
        public virtual ICollection<ReportTemplateAssignment> ReportTemplateAssignments { get; set; }
        public virtual ICollection<ReportTemplateFavorite> ReportTemplateFavorites { get; set; }
        public virtual ICollection<ReportTemplateLog> ReportTemplateLogs { get; set; }
        public virtual ICollection<ResetAudit> ResetAudits { get; set; }
        public virtual ICollection<ScheduleItem> ScheduleItemScheduledByUsers { get; set; }
        public virtual ICollection<ScheduleItem> ScheduleItemScheduledUserNavigations { get; set; }
        public virtual ICollection<SqueezeAggregate> SqueezeAggregates { get; set; }
        public virtual ICollection<TeamFavorite> TeamFavorites { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<TemplateTaskNew> TemplateTaskNewCreatorNavigations { get; set; }
        public virtual ICollection<TemplateTaskNewFavorite> TemplateTaskNewFavorites { get; set; }
        public virtual ICollection<TemplateTaskNew> TemplateTaskNewTemplateApproverNavigations { get; set; }
        public virtual ICollection<UserConfiguration> UserConfigurations { get; set; }
        public virtual ICollection<UserDocumentPermission> UserDocumentPermissions { get; set; }
        public virtual ICollection<UserMessaging> UserMessagingFromUsers { get; set; }
        public virtual ICollection<UserMessaging> UserMessagingToUsers { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserProfileChangeTrace> UserProfileChangeTraces { get; set; }
        public virtual ICollection<UserSecretAnswer> UserSecretAnswers { get; set; }
        public virtual ICollection<UserSqueeze> UserSqueezes { get; set; }
        public virtual ICollection<UserStorageAccountType> UserStorageAccountTypes { get; set; }
        public virtual ICollection<UserTaskAdditionalOwner> UserTaskAdditionalOwners { get; set; }
        public virtual ICollection<UserTaskApprovalRequeriment> UserTaskApprovalRequeriments { get; set; }
        public virtual ICollection<UserTask> UserTaskApproverNavigations { get; set; }
        public virtual ICollection<UserTask> UserTaskBelongsToUserNavigations { get; set; }
        public virtual ICollection<UserTaskComment> UserTaskComments { get; set; }
        public virtual ICollection<UserTaskLastSeen> UserTaskLastSeens { get; set; }
        public virtual ICollection<UserTask> UserTaskTaskAssignedByNavigations { get; set; }
        public virtual ICollection<UserTask> UserTaskTaskCreatedByNavigations { get; set; }
        public virtual ICollection<UserTaskTracer> UserTaskTracerUserIdtoNavigations { get; set; }
        public virtual ICollection<UserTaskTracer> UserTaskTracerUsers { get; set; }
        public virtual ICollection<UsersManager> UsersManagerManagers { get; set; }
        public virtual ICollection<UsersManager> UsersManagerUsers { get; set; }
    }
}

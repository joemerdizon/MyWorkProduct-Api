using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTask
    {
        public UserTask()
        {
            CalendarEvents = new HashSet<CalendarEvent>();
            InverseParent = new HashSet<UserTask>();
            UserSqueezes = new HashSet<UserSqueeze>();
            UserTaskAdditionalOwners = new HashSet<UserTaskAdditionalOwner>();
            UserTaskApprovalRequeriments = new HashSet<UserTaskApprovalRequeriment>();
            UserTaskComments = new HashSet<UserTaskComment>();
            UserTaskDocuments = new HashSet<UserTaskDocument>();
            UserTaskLastSeens = new HashSet<UserTaskLastSeen>();
            UserTaskPlaybookDocuments = new HashSet<UserTaskPlaybookDocument>();
            UserTaskResources = new HashSet<UserTaskResource>();
            UserTaskTracers = new HashSet<UserTaskTracer>();
        }

        public int TaskId { get; set; }
        public int? BelongsToUser { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int? TaskGroupId { get; set; }
        public int? TaskStatusId { get; set; }
        public DateTime? TaskAssignedDate { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public DateTime? TaskCompletedDate { get; set; }
        public int? HeadsUpDays { get; set; }
        public int? HeadsUpHours { get; set; }
        public int? HeadsUpMinutes { get; set; }
        public int? TaskSubGroupId { get; set; }
        public int? LinkToChart { get; set; }
        public int? ParentId { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? AddToCal { get; set; }
        public Guid? BatchId { get; set; }
        public int? TaskAssignedBy { get; set; }
        public int? TaskCreatedBy { get; set; }
        public int? TaskType { get; set; }
        public int? HeadsUp { get; set; }
        public int? Urgent { get; set; }
        public int? Approver { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? TemplateTaskId { get; set; }
        public bool? TemplateTaskApprovable { get; set; }
        public int? ApprovalCondition { get; set; }
        public Guid? RecurrenceId { get; set; }

        public virtual User ApproverNavigation { get; set; }
        public virtual User BelongsToUserNavigation { get; set; }
        public virtual UserTask Parent { get; set; }
        public virtual User TaskAssignedByNavigation { get; set; }
        public virtual User TaskCreatedByNavigation { get; set; }
        public virtual TemplateTaskCategory TaskGroup { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
        public virtual TemplateTaskCategory TaskSubGroup { get; set; }
        public virtual TaskType TaskTypeNavigation { get; set; }
        public virtual TemplateTaskNew TemplateTask { get; set; }
        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; }
        public virtual ICollection<UserTask> InverseParent { get; set; }
        public virtual ICollection<UserSqueeze> UserSqueezes { get; set; }
        public virtual ICollection<UserTaskAdditionalOwner> UserTaskAdditionalOwners { get; set; }
        public virtual ICollection<UserTaskApprovalRequeriment> UserTaskApprovalRequeriments { get; set; }
        public virtual ICollection<UserTaskComment> UserTaskComments { get; set; }
        public virtual ICollection<UserTaskDocument> UserTaskDocuments { get; set; }
        public virtual ICollection<UserTaskLastSeen> UserTaskLastSeens { get; set; }
        public virtual ICollection<UserTaskPlaybookDocument> UserTaskPlaybookDocuments { get; set; }
        public virtual ICollection<UserTaskResource> UserTaskResources { get; set; }
        public virtual ICollection<UserTaskTracer> UserTaskTracers { get; set; }
    }
}

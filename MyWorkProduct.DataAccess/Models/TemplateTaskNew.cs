using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TemplateTaskNew
    {
        public TemplateTaskNew()
        {
            InverseParent = new HashSet<TemplateTaskNew>();
            TaskReportTemplates = new HashSet<TaskReportTemplate>();
            TemplateTaskNewFavorites = new HashSet<TemplateTaskNewFavorite>();
            TemplateTaskPlaybookDocuments = new HashSet<TemplateTaskPlaybookDocument>();
            TemplateTaskResources = new HashSet<TemplateTaskResource>();
            UserTaskComments = new HashSet<UserTaskComment>();
            UserTaskDocuments = new HashSet<UserTaskDocument>();
            UserTasks = new HashSet<UserTask>();
        }

        public int TaskId { get; set; }
        public int? ParentId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int? TaskCategory { get; set; }
        public int? TaskSubCategory { get; set; }
        public bool? ArchiveTask { get; set; }
        public bool? LinkToChart { get; set; }
        public int? ClientId { get; set; }
        public DateTime? TaskCreated { get; set; }
        public int? HeadsUp { get; set; }
        public int? Urgent { get; set; }
        public bool? Approvable { get; set; }
        public int? TemplateApprover { get; set; }
        public int? Creator { get; set; }
        public bool? Approved { get; set; }
        public int? ApprovalCondition { get; set; }
        public bool? Auditable { get; set; }
        public bool? Archive { get; set; }
        public bool? Assignable { get; set; }

        public virtual Client Client { get; set; }
        public virtual User CreatorNavigation { get; set; }
        public virtual TemplateTaskNew Parent { get; set; }
        public virtual TemplateTaskCategory TaskCategoryNavigation { get; set; }
        public virtual TemplateTaskCategory TaskSubCategoryNavigation { get; set; }
        public virtual User TemplateApproverNavigation { get; set; }
        public virtual ICollection<TemplateTaskNew> InverseParent { get; set; }
        public virtual ICollection<TaskReportTemplate> TaskReportTemplates { get; set; }
        public virtual ICollection<TemplateTaskNewFavorite> TemplateTaskNewFavorites { get; set; }
        public virtual ICollection<TemplateTaskPlaybookDocument> TemplateTaskPlaybookDocuments { get; set; }
        public virtual ICollection<TemplateTaskResource> TemplateTaskResources { get; set; }
        public virtual ICollection<UserTaskComment> UserTaskComments { get; set; }
        public virtual ICollection<UserTaskDocument> UserTaskDocuments { get; set; }
        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}

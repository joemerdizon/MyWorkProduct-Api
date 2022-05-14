using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportTemplateAssignment
    {
        public ReportTemplateAssignment()
        {
            ReportTemplateAssignmentAssignees = new HashSet<ReportTemplateAssignmentAssignee>();
        }

        public int ReportTemplateAssignmentId { get; set; }
        public int ReportTemplateId { get; set; }
        public string Name { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime DueDate { get; set; }
        public int? AssignedBy { get; set; }
        public bool? Archived { get; set; }
        public int? Status { get; set; }
        public DateTime StatusLastUpdateDate { get; set; }

        public virtual User AssignedByNavigation { get; set; }
        public virtual ReportTemplate ReportTemplate { get; set; }
        public virtual ICollection<ReportTemplateAssignmentAssignee> ReportTemplateAssignmentAssignees { get; set; }
    }
}

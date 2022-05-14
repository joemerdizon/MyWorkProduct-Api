using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportTemplateAssignmentAssignee
    {
        public int ReportTemplateAssignmentAssigneeId { get; set; }
        public int ReportTemplateAssignmentId { get; set; }
        public int UserId { get; set; }

        public virtual ReportTemplateAssignment ReportTemplateAssignment { get; set; }
        public virtual User User { get; set; }
    }
}

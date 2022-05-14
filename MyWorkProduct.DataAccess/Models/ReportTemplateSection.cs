using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportTemplateSection
    {
        public ReportTemplateSection()
        {
            TaskReportTemplates = new HashSet<TaskReportTemplate>();
        }

        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TemplateReportId { get; set; }
        public int? Order { get; set; }

        public virtual ReportTemplate TemplateReport { get; set; }
        public virtual ICollection<TaskReportTemplate> TaskReportTemplates { get; set; }
    }
}

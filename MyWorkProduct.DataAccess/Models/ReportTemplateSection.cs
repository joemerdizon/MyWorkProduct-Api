using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportTemplateSection
    {
        public ReportTemplateSection()
        {
            ReportTemplateTasks = new HashSet<ReportTemplateTask>();
        }

        public int ReportTemplateSectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ReportTemplateId { get; set; }
        public int? Order { get; set; }

        public virtual ReportTemplate ReportTemplate { get; set; }
        public virtual ICollection<ReportTemplateTask> ReportTemplateTasks { get; set; }
    }
}

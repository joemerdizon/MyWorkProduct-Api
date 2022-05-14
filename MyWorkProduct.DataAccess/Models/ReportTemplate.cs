using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportTemplate
    {
        public ReportTemplate()
        {
            ReportTemplateAssignments = new HashSet<ReportTemplateAssignment>();
            ReportTemplateFavorites = new HashSet<ReportTemplateFavorite>();
            ReportTemplateLogs = new HashSet<ReportTemplateLog>();
            ReportTemplateSections = new HashSet<ReportTemplateSection>();
        }

        public int ReportTemplateId { get; set; }
        public string TemplateKey { get; set; }
        public string DocumentName { get; set; }
        public int? ClientId { get; set; }
        public int? UserTitleId { get; set; }
        public bool? TemplateReport { get; set; }
        public bool? Archive { get; set; }

        public virtual UserTitle UserTitle { get; set; }
        public virtual ICollection<ReportTemplateAssignment> ReportTemplateAssignments { get; set; }
        public virtual ICollection<ReportTemplateFavorite> ReportTemplateFavorites { get; set; }
        public virtual ICollection<ReportTemplateLog> ReportTemplateLogs { get; set; }
        public virtual ICollection<ReportTemplateSection> ReportTemplateSections { get; set; }
    }
}

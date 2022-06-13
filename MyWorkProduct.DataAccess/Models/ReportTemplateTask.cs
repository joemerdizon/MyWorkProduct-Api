using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportTemplateTask
    {
        public int ReportTemplateTaskId { get; set; }
        public decimal? TaskDocRef { get; set; }
        public string TemplateKey { get; set; }
        public string Roles { get; set; }
        public int? TemplateTaskId { get; set; }
        public int ReportTemplateSectionId { get; set; }
        public int? ClientId { get; set; }
        public string DueDate { get; set; }
        public int? TimeRemaining { get; set; }
        public string TimeUnit { get; set; }
        public int? Order { get; set; }
        public int? RowId { get; set; }

        public virtual ReportTemplateSection ReportTemplateSection { get; set; }
        public virtual TemplateTask TemplateTask { get; set; }
    }
}

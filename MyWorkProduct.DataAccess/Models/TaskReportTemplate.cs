using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TaskReportTemplate
    {
        public int RowId { get; set; }
        public decimal? TaskDocRef { get; set; }
        public string TemplateKey { get; set; }
        public string Roles { get; set; }
        public int? TemplateTaskId { get; set; }
        public int SectionId { get; set; }
        public int? ClientId { get; set; }
        public string DueDate { get; set; }
        public int? TimeRemaining { get; set; }
        public string TimeUnit { get; set; }
        public int? Order { get; set; }

        public virtual ReportTemplateSection Section { get; set; }
        public virtual TemplateTaskNew TemplateTask { get; set; }
    }
}

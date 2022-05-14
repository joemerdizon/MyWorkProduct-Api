using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportTemplateLog
    {
        public int ReportTemplateLogId { get; set; }
        public int ReportTemplateId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual ReportTemplate ReportTemplate { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ReportDocLog
    {
        public int ReportDocId { get; set; }
        public string ReportDocName { get; set; }
        public string ReportDocFullPath { get; set; }
        public int ReportDocGeneratedBy { get; set; }
        public int ReportDocBelongsTo { get; set; }
        public DateTime ReportDocDateTime { get; set; }
        public bool? Archive { get; set; }

        public virtual User ReportDocBelongsToNavigation { get; set; }
        public virtual User ReportDocGeneratedByNavigation { get; set; }
    }
}

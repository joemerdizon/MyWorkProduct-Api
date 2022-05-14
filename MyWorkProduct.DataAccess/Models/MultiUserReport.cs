using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class MultiUserReport
    {
        public int ReportId { get; set; }
        public string Name { get; set; }
        public string Users { get; set; }
        public string Url { get; set; }
        public int GeneratedBy { get; set; }
        public DateTime Time { get; set; }
        public bool Archived { get; set; }

        public virtual User GeneratedByNavigation { get; set; }
    }
}

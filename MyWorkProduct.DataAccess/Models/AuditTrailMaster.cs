using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class AuditTrailMaster
    {
        public int AuditTrailId { get; set; }
        public int? TaskId { get; set; }
        public string TaskDescription { get; set; }
        public int? UserId { get; set; }
        public string Notes { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}

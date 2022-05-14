using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ResetAudit
    {
        public int ResetAuditId { get; set; }
        public DateTime? ResetStartTime { get; set; }
        public DateTime? ResetEndTime { get; set; }
        public int? ResetStatus { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}

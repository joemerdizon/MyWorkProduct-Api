using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserProfileChangeTrace
    {
        public int TraceRowId { get; set; }
        public int? UserId { get; set; }
        public Guid? TraceId { get; set; }

        public virtual User User { get; set; }
    }
}

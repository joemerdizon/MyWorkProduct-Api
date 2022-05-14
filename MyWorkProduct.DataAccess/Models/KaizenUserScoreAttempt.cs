using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class KaizenUserScoreAttempt
    {
        public int KaizenScoreAttempts { get; set; }
        public int? UserId { get; set; }
        public int? VoteTypeId { get; set; }
        public int? KaizenId { get; set; }

        public virtual Kaizen Kaizen { get; set; }
        public virtual User User { get; set; }
    }
}

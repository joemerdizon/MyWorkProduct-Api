using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTaskLastSeen
    {
        public int UserTaskLastSeenId { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }

        public virtual UserTask Task { get; set; }
        public virtual User User { get; set; }
    }
}

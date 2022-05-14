using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTaskAdditionalOwner
    {
        public int AdditionalOwnerId { get; set; }
        public int? TaskId { get; set; }
        public int? TaskOwnerLookupId { get; set; }
        public int? UserId { get; set; }

        public virtual UserTask Task { get; set; }
        public virtual TaskOwnerLookup TaskOwnerLookup { get; set; }
        public virtual User User { get; set; }
    }
}

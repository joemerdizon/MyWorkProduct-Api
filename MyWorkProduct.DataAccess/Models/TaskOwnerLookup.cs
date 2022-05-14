using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TaskOwnerLookup
    {
        public TaskOwnerLookup()
        {
            UserTaskAdditionalOwners = new HashSet<UserTaskAdditionalOwner>();
        }

        public int TaskOwnerId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserTaskAdditionalOwner> UserTaskAdditionalOwners { get; set; }
    }
}

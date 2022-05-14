using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ActionList
    {
        public ActionList()
        {
            NotificationMasters = new HashSet<NotificationMaster>();
        }

        public int ActionItemId { get; set; }
        public string ActionName { get; set; }
        public string ActionDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<NotificationMaster> NotificationMasters { get; set; }
    }
}

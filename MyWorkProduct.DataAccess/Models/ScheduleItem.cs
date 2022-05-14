using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ScheduleItem
    {
        public ScheduleItem()
        {
            ScheduleItemsDetails = new HashSet<ScheduleItemsDetail>();
        }

        public int ScheduleItemId { get; set; }
        public string ScheduleItemName { get; set; }
        public DateTime? ScheduleItemFrom { get; set; }
        public DateTime? SchedlueItemTo { get; set; }
        public int? ScheduledByUserId { get; set; }
        public int? ResourceId { get; set; }
        public int? ScheduledUser { get; set; }

        public virtual Resource Resource { get; set; }
        public virtual User ScheduledByUser { get; set; }
        public virtual User ScheduledUserNavigation { get; set; }
        public virtual ICollection<ScheduleItemsDetail> ScheduleItemsDetails { get; set; }
    }
}

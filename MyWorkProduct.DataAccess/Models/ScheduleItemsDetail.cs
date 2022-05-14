using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ScheduleItemsDetail
    {
        public int ScheduleItemDetailId { get; set; }
        public DateTime? ScheduleStartFrom { get; set; }
        public DateTime? ScheduleStartTo { get; set; }
        public string ScheduleItemType { get; set; }
        public int? ScheduleId { get; set; }

        public virtual ScheduleItem Schedule { get; set; }
    }
}

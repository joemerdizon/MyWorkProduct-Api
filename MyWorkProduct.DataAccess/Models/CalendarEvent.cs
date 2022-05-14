using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class CalendarEvent
    {
        public int CalendarEventId { get; set; }
        public int? BelongsToUser { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TimeZone { get; set; }
        public string Repeat { get; set; }
        public string RepeatOptions { get; set; }
        public DateTime? RepeatUntil { get; set; }
        public bool? Enabled { get; set; }
        public bool? AllDay { get; set; }
        public int? UserTaskId { get; set; }

        public virtual User BelongsToUserNavigation { get; set; }
        public virtual UserTask UserTask { get; set; }
    }
}

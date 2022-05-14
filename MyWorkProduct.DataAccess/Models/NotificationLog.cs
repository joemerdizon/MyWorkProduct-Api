using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class NotificationLog
    {
        public NotificationLog()
        {
            NotificationLogDevices = new HashSet<NotificationLogDevice>();
        }

        public int NotificationLogId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public int UserId { get; set; }
        public int ObjectId { get; set; }
        public string ObjectType { get; set; }
        public int? NotificationItemId { get; set; }

        public virtual NotificationItem NotificationItem { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<NotificationLogDevice> NotificationLogDevices { get; set; }
    }
}

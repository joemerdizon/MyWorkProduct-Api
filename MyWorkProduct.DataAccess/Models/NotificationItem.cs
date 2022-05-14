using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class NotificationItem
    {
        public NotificationItem()
        {
            NotificationGlobalSubscriptions = new HashSet<NotificationGlobalSubscription>();
            NotificationLogs = new HashSet<NotificationLog>();
            NotificationSuscriptions = new HashSet<NotificationSuscription>();
        }

        public int NotificationItemId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public string DefaultDevices { get; set; }
        public string Link { get; set; }
        public string NotificationKey { get; set; }
        public string Description2 { get; set; }
        public string Tooltip { get; set; }
        public bool? Default { get; set; }

        public virtual ICollection<NotificationGlobalSubscription> NotificationGlobalSubscriptions { get; set; }
        public virtual ICollection<NotificationLog> NotificationLogs { get; set; }
        public virtual ICollection<NotificationSuscription> NotificationSuscriptions { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class NotificationGlobalSubscription
    {
        public int NotificationGlobalSuscriptionId { get; set; }
        public int NotificationItemId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual NotificationItem NotificationItem { get; set; }
    }
}

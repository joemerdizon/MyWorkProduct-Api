using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class NotificationSuscription
    {
        public int NotificationSuscriptionId { get; set; }
        public int NotificationItemId { get; set; }
        public int UserId { get; set; }

        public virtual NotificationItem NotificationItem { get; set; }
        public virtual User User { get; set; }
    }
}

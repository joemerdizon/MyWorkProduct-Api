using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class NotificationMaster
    {
        public int NotificationId { get; set; }
        public int? ActionItemId { get; set; }
        public int? NotificationFromUserId { get; set; }
        public int? NotificationToUserId { get; set; }
        public DateTime? NotificationStartDate { get; set; }
        public DateTime? NotificationEndDate { get; set; }
        public bool? IsNotificationAssigned { get; set; }
        public DateTime? NotificationRegistrationDate { get; set; }
        public DateTime? NotificationAcceptanceDate { get; set; }

        public virtual ActionList ActionItem { get; set; }
        public virtual User NotificationFromUser { get; set; }
        public virtual User NotificationToUser { get; set; }
    }
}

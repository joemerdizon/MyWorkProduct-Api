using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class NotificationLogDevice
    {
        public int NotificationLogDeviceId { get; set; }
        public int NotificationLogId { get; set; }
        public string DeviceId { get; set; }
        public bool Sent { get; set; }
        public DateTime DentDate { get; set; }

        public virtual NotificationLog NotificationLog { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserMessaging
    {
        public int MessageId { get; set; }
        public int? FromUserId { get; set; }
        public int? ToUserId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public DateTime? MessageTimestamp { get; set; }
        public bool? ReadStatus { get; set; }
        public bool? Archived { get; set; }
        public int? ParentId { get; set; }

        public virtual User FromUser { get; set; }
        public virtual User ToUser { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class PasswordChangeRequest
    {
        public string PasswordChangeRequestId { get; set; }
        public int UserId { get; set; }
        public DateTime? Time { get; set; }
    }
}

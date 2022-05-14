using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTaskApprovalRequeriment
    {
        public int ApprovalRequerimentId { get; set; }
        public int? TaskId { get; set; }
        public string Review { get; set; }
        public int UserId { get; set; }
        public DateTime ChangeDate { get; set; }
        public bool? IsHistory { get; set; }
        public int? ProviderStorageAccountId { get; set; }
        public string BoxDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public bool? Archived { get; set; }

        public virtual UserTask Task { get; set; }
        public virtual User User { get; set; }
    }
}

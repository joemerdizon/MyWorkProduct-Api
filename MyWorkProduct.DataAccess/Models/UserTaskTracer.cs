using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTaskTracer
    {
        public int TraceId { get; set; }
        public int TaskId { get; set; }
        public string Comment { get; set; }
        public int StatusFrom { get; set; }
        public int StatusTo { get; set; }
        public int UserId { get; set; }
        public bool? Read { get; set; }
        public DateTime ChangeDate { get; set; }
        public int? UserIdto { get; set; }

        public virtual TaskStatus StatusFromNavigation { get; set; }
        public virtual TaskStatus StatusToNavigation { get; set; }
        public virtual UserTask Task { get; set; }
        public virtual User User { get; set; }
        public virtual User UserIdtoNavigation { get; set; }
    }
}

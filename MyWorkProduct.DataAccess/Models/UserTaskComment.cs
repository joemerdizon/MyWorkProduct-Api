using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTaskComment
    {
        public int CommentId { get; set; }
        public int? TaskId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime Moment { get; set; }
        public int? TemplateTaskId { get; set; }

        public virtual UserTask Task { get; set; }
        public virtual TemplateTaskNew TemplateTask { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TaskStatus
    {
        public TaskStatus()
        {
            UserTaskTracerStatusFromNavigations = new HashSet<UserTaskTracer>();
            UserTaskTracerStatusToNavigations = new HashSet<UserTaskTracer>();
            UserTasks = new HashSet<UserTask>();
        }

        public int TaskStatusId { get; set; }
        public string TaskStatusDescription { get; set; }

        public virtual ICollection<UserTaskTracer> UserTaskTracerStatusFromNavigations { get; set; }
        public virtual ICollection<UserTaskTracer> UserTaskTracerStatusToNavigations { get; set; }
        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}

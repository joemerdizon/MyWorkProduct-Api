using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TaskType
    {
        public TaskType()
        {
            UserTasks = new HashSet<UserTask>();
        }

        public int TaskTypeId { get; set; }
        public string TaskTypeDescription { get; set; }

        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTaskResource
    {
        public int ResourceId { get; set; }
        public int? TaskId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceLink { get; set; }
        public int? Question { get; set; }

        public virtual UserTask Task { get; set; }
    }
}

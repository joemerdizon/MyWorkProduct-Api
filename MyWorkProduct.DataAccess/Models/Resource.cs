using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Resource
    {
        public Resource()
        {
            ScheduleItems = new HashSet<ScheduleItem>();
        }

        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceDescription { get; set; }
        public int? ResourceAvailabityStatusId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DepartmentBranchId { get; set; }

        public virtual Department Department { get; set; }
        public virtual DepartmentBranch DepartmentBranch { get; set; }
        public virtual ResourceAvailStatus ResourceAvailabityStatus { get; set; }
        public virtual ICollection<ScheduleItem> ScheduleItems { get; set; }
    }
}

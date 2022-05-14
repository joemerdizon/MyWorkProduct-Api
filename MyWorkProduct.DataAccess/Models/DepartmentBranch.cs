using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class DepartmentBranch
    {
        public DepartmentBranch()
        {
            Resources = new HashSet<Resource>();
        }

        public int DepartmentBranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchAddressLine1 { get; set; }
        public string BranchAddressLine2 { get; set; }
        public string City { get; set; }
        public int? State { get; set; }
        public string Zip { get; set; }
        public string BranchDescription { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Usstate StateNavigation { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}

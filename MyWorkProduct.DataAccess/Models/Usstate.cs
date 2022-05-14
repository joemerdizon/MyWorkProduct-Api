using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Usstate
    {
        public Usstate()
        {
            DepartmentBranches = new HashSet<DepartmentBranch>();
            Users = new HashSet<User>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<DepartmentBranch> DepartmentBranches { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

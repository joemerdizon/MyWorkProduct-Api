using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Department
    {
        public Department()
        {
            DepartmentBranches = new HashSet<DepartmentBranch>();
            Resources = new HashSet<Resource>();
            UserTitles = new HashSet<UserTitle>();
            Users = new HashSet<User>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int? ClientId { get; set; }
        public int? BusinessStartTime { get; set; }
        public int? BusinessEndTime { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<DepartmentBranch> DepartmentBranches { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<UserTitle> UserTitles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

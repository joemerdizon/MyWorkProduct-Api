using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class OrganizationHierarchy
    {
        public int RelationshipId { get; set; }
        public int? ManagerUserId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ClientId { get; set; }
        public int? UserLevel { get; set; }

        public virtual Client Client { get; set; }
        public virtual User Employee { get; set; }
        public virtual User ManagerUser { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Role
    {
        public Role()
        {
            ClientUserRoles = new HashSet<ClientUserRole>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleDescription { get; set; }

        public virtual ICollection<ClientUserRole> ClientUserRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

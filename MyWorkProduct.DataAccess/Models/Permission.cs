using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Permission
    {
        public Permission()
        {
            UserPermissions = new HashSet<UserPermission>();
            UserTitlePermissions = new HashSet<UserTitlePermission>();
        }

        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Section { get; set; }
        public string PermissionKey { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserTitlePermission> UserTitlePermissions { get; set; }
    }
}

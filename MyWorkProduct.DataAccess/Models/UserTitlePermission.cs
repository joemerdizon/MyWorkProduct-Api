using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTitlePermission
    {
        public int PermissionId { get; set; }
        public int UserTitleId { get; set; }
        public int Id { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual UserTitle UserTitle { get; set; }
    }
}

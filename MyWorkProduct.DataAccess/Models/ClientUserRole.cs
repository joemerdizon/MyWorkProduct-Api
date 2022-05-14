using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ClientUserRole
    {
        public int RowId { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}

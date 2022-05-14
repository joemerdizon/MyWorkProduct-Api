using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UsersManager
    {
        public int RowId { get; set; }
        public int UserId { get; set; }
        public int ManagerId { get; set; }

        public virtual User Manager { get; set; }
        public virtual User User { get; set; }
    }
}

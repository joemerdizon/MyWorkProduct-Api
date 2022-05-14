using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserAvailableStatus
    {
        public UserAvailableStatus()
        {
            Users = new HashSet<User>();
        }

        public int AvailabilityId { get; set; }
        public string AvailabilityDescription { get; set; }
        public string ImagePath { get; set; }
        public int? ClientId { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

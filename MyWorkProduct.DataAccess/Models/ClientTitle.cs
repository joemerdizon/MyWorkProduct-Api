using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ClientTitle
    {
        public ClientTitle()
        {
            Users = new HashSet<User>();
        }

        public int TitleId { get; set; }
        public int ClientId { get; set; }
        public string TitleName { get; set; }
        public string ColorFrom { get; set; }
        public string ColorTo { get; set; }
        public bool? Archived { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

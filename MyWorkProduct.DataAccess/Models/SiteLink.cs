using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class SiteLink
    {
        public int NavId { get; set; }
        public string NavTitle { get; set; }
        public string NavLink { get; set; }
        public string NavImage { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }
        public int? NavOrder { get; set; }
        public string NavSection { get; set; }
        public bool? Beta { get; set; }
    }
}

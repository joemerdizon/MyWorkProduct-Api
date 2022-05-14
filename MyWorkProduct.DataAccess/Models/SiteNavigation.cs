using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class SiteNavigation
    {
        public int NavId { get; set; }
        public string NavTitle { get; set; }
        public string NavLink { get; set; }
        public string NavImage { get; set; }
        public int? NavOrder { get; set; }
        public string NavSection { get; set; }
        public bool? Beta { get; set; }
    }
}

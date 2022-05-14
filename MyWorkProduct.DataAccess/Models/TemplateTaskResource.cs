using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TemplateTaskResource
    {
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceUrl { get; set; }
        public int? TaskId { get; set; }
        public int? Question { get; set; }

        public virtual TemplateTaskNew Task { get; set; }
    }
}

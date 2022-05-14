using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ResourceAvailStatus
    {
        public ResourceAvailStatus()
        {
            Resources = new HashSet<Resource>();
        }

        public int ResourceAvailabityStatusId { get; set; }
        public string StatusDescription { get; set; }
        public string StatusCategory { get; set; }
        public int? ResourceId { get; set; }
        public int? ImageId { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
    }
}

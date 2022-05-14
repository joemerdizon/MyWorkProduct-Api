using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ProductUpdate
    {
        public ProductUpdate()
        {
            InversePreviousProductUpdate = new HashSet<ProductUpdate>();
        }

        public int ProductUpdateId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public int? PreviousProductUpdateId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? Active { get; set; }

        public virtual ProductUpdate PreviousProductUpdate { get; set; }
        public virtual ICollection<ProductUpdate> InversePreviousProductUpdate { get; set; }
    }
}

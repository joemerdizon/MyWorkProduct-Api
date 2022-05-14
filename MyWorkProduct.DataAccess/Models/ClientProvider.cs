using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ClientProvider
    {
        public int ProviderId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Provider Provider { get; set; }
    }
}

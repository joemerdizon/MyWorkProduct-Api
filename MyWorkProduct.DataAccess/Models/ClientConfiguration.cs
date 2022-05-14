using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ClientConfiguration
    {
        public int ClientConfigId { get; set; }
        public int? ClientId { get; set; }
        public int? EntityId { get; set; }
        public string EntityValue { get; set; }

        public virtual Client Client { get; set; }
        public virtual ClientConfigEntity Entity { get; set; }
    }
}

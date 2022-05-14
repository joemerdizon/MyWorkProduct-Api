using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ClientConfigEntity
    {
        public ClientConfigEntity()
        {
            ClientConfigurations = new HashSet<ClientConfiguration>();
        }

        public int ClientConfigEntityId { get; set; }
        public string EntityName { get; set; }
        public string EntityDescription { get; set; }
        public string DefaultValue { get; set; }

        public virtual ICollection<ClientConfiguration> ClientConfigurations { get; set; }
    }
}

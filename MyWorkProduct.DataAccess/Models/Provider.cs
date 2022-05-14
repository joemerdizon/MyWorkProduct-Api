using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Provider
    {
        public Provider()
        {
            ClientProviders = new HashSet<ClientProvider>();
            StorageAccountTypes = new HashSet<StorageAccountType>();
        }

        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<ClientProvider> ClientProviders { get; set; }
        public virtual ICollection<StorageAccountType> StorageAccountTypes { get; set; }
    }
}

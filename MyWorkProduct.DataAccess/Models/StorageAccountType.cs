using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class StorageAccountType
    {
        public StorageAccountType()
        {
            ProviderStorageAccountTypes = new HashSet<ProviderStorageAccountType>();
            UserStorageAccountTypes = new HashSet<UserStorageAccountType>();
        }

        public int AccountTypeId { get; set; }
        public string AccountName { get; set; }
        public int? ProviderId { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual ICollection<ProviderStorageAccountType> ProviderStorageAccountTypes { get; set; }
        public virtual ICollection<UserStorageAccountType> UserStorageAccountTypes { get; set; }
    }
}

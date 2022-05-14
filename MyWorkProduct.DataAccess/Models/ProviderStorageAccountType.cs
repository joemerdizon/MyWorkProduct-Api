using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ProviderStorageAccountType
    {
        public int AccountTypeId { get; set; }
        public int ProviderStorageAccountTypeId { get; set; }
        public int? UserId { get; set; }

        public virtual StorageAccountType AccountType { get; set; }
        public virtual User User { get; set; }
    }
}

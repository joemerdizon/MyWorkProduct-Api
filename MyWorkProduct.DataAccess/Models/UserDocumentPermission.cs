using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserDocumentPermission
    {
        public int PermissionId { get; set; }
        public int UserStorageAccountId { get; set; }
        public string ProviderDocumentId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual UserStorageAccountType UserStorageAccount { get; set; }
    }
}

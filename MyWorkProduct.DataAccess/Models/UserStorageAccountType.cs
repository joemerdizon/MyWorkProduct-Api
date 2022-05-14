using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserStorageAccountType
    {
        public UserStorageAccountType()
        {
            UserDocumentPermissions = new HashSet<UserDocumentPermission>();
        }

        public int UserStorageAccountId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? LastRefresh { get; set; }
        public int AccessTokenExpireIn { get; set; }
        public string ProviderTempFolderId { get; set; }
        public int? UserId { get; set; }
        public int? StorageAccountTypeId { get; set; }
        public int? ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual StorageAccountType StorageAccountType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserDocumentPermission> UserDocumentPermissions { get; set; }
    }
}

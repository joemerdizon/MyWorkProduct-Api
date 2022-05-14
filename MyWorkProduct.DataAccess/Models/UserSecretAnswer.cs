using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserSecretAnswer
    {
        public int UserSecretAnswerId { get; set; }
        public int? SecretQuestionId { get; set; }
        public string SecretAnswer { get; set; }
        public int? UserId { get; set; }

        public virtual SecretQuestion SecretQuestion { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class SecretQuestion
    {
        public SecretQuestion()
        {
            UserSecretAnswers = new HashSet<UserSecretAnswer>();
        }

        public int SecretQuestionId { get; set; }
        public string SecretQuestion1 { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<UserSecretAnswer> UserSecretAnswers { get; set; }
    }
}

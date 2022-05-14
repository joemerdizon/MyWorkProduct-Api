using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class PlaybookFavorite
    {
        public int FavoriteId { get; set; }
        public int UserId { get; set; }
        public int PlaybookDocumentId { get; set; }

        public virtual PlaybookDocument PlaybookDocument { get; set; }
        public virtual User User { get; set; }
    }
}

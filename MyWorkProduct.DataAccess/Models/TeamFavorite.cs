using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TeamFavorite
    {
        public int TeamFavoriteId { get; set; }
        public int TeamId { get; set; }
        public int UserId { get; set; }

        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}

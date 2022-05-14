using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TemplateTaskNewFavorite
    {
        public int TemplateTaskNewFavoriteId { get; set; }
        public int TemplateTaskNewId { get; set; }
        public int UserId { get; set; }

        public virtual TemplateTaskNew TemplateTaskNew { get; set; }
        public virtual User User { get; set; }
    }
}

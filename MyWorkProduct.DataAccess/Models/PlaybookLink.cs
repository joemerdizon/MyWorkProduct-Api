using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class PlaybookLink
    {
        public int LinkId { get; set; }
        public string Url { get; set; }
        public int PlaybookDocumentId { get; set; }
        public string Name { get; set; }

        public virtual PlaybookDocument PlaybookDocument { get; set; }
    }
}

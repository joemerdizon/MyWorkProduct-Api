using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class PlaybookNew
    {
        public int PlaybookId { get; set; }
        public int? ClientId { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Description { get; set; }
        public string DocumentCat3 { get; set; }
        public string MultimediaCat3 { get; set; }
        public string Category4 { get; set; }
        public string DocumentCat4 { get; set; }
        public string MultimediaCat4 { get; set; }
        public bool? IsArchive { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ModifiedByUser { get; set; }
    }
}

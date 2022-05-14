using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Tip
    {
        public int? TipId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PreviousTipId { get; set; }
        public string CreationDate { get; set; }
        public bool? Active { get; set; }
    }
}

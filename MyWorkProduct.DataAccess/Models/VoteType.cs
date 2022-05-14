using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class VoteType
    {
        public int VoteTypeId { get; set; }
        public string Title { get; set; }
        public int? Score { get; set; }
    }
}

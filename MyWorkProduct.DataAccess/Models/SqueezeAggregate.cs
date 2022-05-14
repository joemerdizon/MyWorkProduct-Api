using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class SqueezeAggregate
    {
        public int SqueezeId { get; set; }
        public int UserId { get; set; }
        public int Safety { get; set; }
        public int Quality { get; set; }
        public int Efficiency { get; set; }
        public int Effectiveness { get; set; }
        public int Zest { get; set; }

        public virtual User User { get; set; }
    }
}

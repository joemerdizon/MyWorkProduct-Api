using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserSqueeze
    {
        public int SqueezeId { get; set; }
        public int UserId { get; set; }
        public int? TaskId { get; set; }
        public int Safety { get; set; }
        public int Quality { get; set; }
        public int Efficiency { get; set; }
        public int Effectiveness { get; set; }
        public int Zest { get; set; }
        public bool Processed { get; set; }
        public string Description { get; set; }

        public virtual UserTask Task { get; set; }
        public virtual User User { get; set; }
    }
}

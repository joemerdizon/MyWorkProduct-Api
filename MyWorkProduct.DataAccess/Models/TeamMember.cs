using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TeamMember
    {
        public TeamMember()
        {
            InverseBoss = new HashSet<TeamMember>();
        }

        public int TeamMemberId { get; set; }
        public int TeamId { get; set; }
        public int UserId { get; set; }
        public int? BossId { get; set; }
        public string PositionName { get; set; }
        public string PositionDescription { get; set; }

        public virtual TeamMember Boss { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TeamMember> InverseBoss { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Team
    {
        public Team()
        {
            TeamFavorites = new HashSet<TeamFavorite>();
            TeamMembers = new HashSet<TeamMember>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Manager { get; set; }
        public int Client { get; set; }
        public bool Archive { get; set; }

        public virtual Client ClientNavigation { get; set; }
        public virtual User ManagerNavigation { get; set; }
        public virtual ICollection<TeamFavorite> TeamFavorites { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
    }
}

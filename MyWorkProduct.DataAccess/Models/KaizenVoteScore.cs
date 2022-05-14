using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class KaizenVoteScore
    {
        public int Id { get; set; }
        public int UserIdVoting { get; set; }
        public int KaizenItemId { get; set; }
        public int Vote { get; set; }
        public int UserIdVoted { get; set; }
        public int Score { get; set; }

        public virtual KaizenItem KaizenItem { get; set; }
        public virtual User UserIdVotedNavigation { get; set; }
        public virtual User UserIdVotingNavigation { get; set; }
    }
}

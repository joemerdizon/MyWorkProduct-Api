using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class KaizenConfig
    {
        public int Id { get; set; }
        public int AutomaticScoreForNewEntries { get; set; }
        public int? ScoreForReplies { get; set; }
        public int? ScoreUnitForVotes { get; set; }
        public int? ScoreForTitle { get; set; }
        public int? ScoreForDescription { get; set; }
        public int? ScoreForQuestion1 { get; set; }
        public int? ScoreForQuestion2 { get; set; }
        public int? ScoreForQuestion3 { get; set; }
        public int? ScoreForEachWhy { get; set; }
        public int? ScoreForEachAttach { get; set; }
    }
}

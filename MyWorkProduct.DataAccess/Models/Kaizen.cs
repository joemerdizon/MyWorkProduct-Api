using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Kaizen
    {
        public Kaizen()
        {
            InverseParent = new HashSet<Kaizen>();
            KaizenUserScoreAttempts = new HashSet<KaizenUserScoreAttempt>();
        }

        public int KaizenId { get; set; }
        public string KaizenTitle { get; set; }
        public int? TotalPoints { get; set; }
        public int? KaizenTopCat { get; set; }
        public int? KaizenSecondCat { get; set; }
        public int? SubmittedByUserId { get; set; }
        public int? ParentId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Why1 { get; set; }
        public string Why2 { get; set; }
        public string Why3 { get; set; }
        public string Why4 { get; set; }
        public string Why5 { get; set; }
        public string What1 { get; set; }
        public string What2 { get; set; }
        public string How { get; set; }

        public virtual KaizenSecondCat KaizenSecondCatNavigation { get; set; }
        public virtual KaizenTopCat KaizenTopCatNavigation { get; set; }
        public virtual Kaizen Parent { get; set; }
        public virtual User SubmittedByUser { get; set; }
        public virtual ICollection<Kaizen> InverseParent { get; set; }
        public virtual ICollection<KaizenUserScoreAttempt> KaizenUserScoreAttempts { get; set; }
    }
}

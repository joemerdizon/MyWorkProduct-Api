using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class KaizenItem
    {
        public KaizenItem()
        {
            InverseKaizenItemParent = new HashSet<KaizenItem>();
            KaizenVoteScores = new HashSet<KaizenVoteScore>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int? KaizenItemParentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public bool? Visible { get; set; }
        public int Category1 { get; set; }
        public int Category2 { get; set; }
        public DateTime Date { get; set; }
        public string Why1 { get; set; }
        public string Why2 { get; set; }
        public string Why3 { get; set; }
        public string Why4 { get; set; }
        public string Why5 { get; set; }
        public string What1 { get; set; }
        public string What2 { get; set; }
        public string How { get; set; }
        public string Attachments { get; set; }

        public virtual KaizenTopCat Category1Navigation { get; set; }
        public virtual KaizenSecondCat Category2Navigation { get; set; }
        public virtual KaizenItem KaizenItemParent { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<KaizenItem> InverseKaizenItemParent { get; set; }
        public virtual ICollection<KaizenVoteScore> KaizenVoteScores { get; set; }
    }
}

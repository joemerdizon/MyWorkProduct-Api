using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class KaizenTopCat
    {
        public KaizenTopCat()
        {
            KaizenItems = new HashSet<KaizenItem>();
            Kaizens = new HashSet<Kaizen>();
        }

        public int KaizenTopCatId { get; set; }
        public string KaizenTopCatName { get; set; }

        public virtual ICollection<KaizenItem> KaizenItems { get; set; }
        public virtual ICollection<Kaizen> Kaizens { get; set; }
    }
}

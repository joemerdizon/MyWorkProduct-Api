using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class KaizenSecondCat
    {
        public KaizenSecondCat()
        {
            KaizenItems = new HashSet<KaizenItem>();
            Kaizens = new HashSet<Kaizen>();
        }

        public int KaizenSecondCatId { get; set; }
        public string KaizenSecondName { get; set; }

        public virtual ICollection<KaizenItem> KaizenItems { get; set; }
        public virtual ICollection<Kaizen> Kaizens { get; set; }
    }
}

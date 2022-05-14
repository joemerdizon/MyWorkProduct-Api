using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Playbook
    {
        public Playbook()
        {
            InverseParent = new HashSet<Playbook>();
            PlaybookDocuments = new HashSet<PlaybookDocument>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ClientId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ParentId { get; set; }
        public bool? Active { get; set; }

        public virtual Playbook Parent { get; set; }
        public virtual ICollection<Playbook> InverseParent { get; set; }
        public virtual ICollection<PlaybookDocument> PlaybookDocuments { get; set; }
    }
}

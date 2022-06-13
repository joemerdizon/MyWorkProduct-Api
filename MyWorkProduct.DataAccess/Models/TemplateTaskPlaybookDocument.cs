using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TemplateTaskPlaybookDocument
    {
        public int TaskId { get; set; }
        public int DocumentId { get; set; }

        public virtual PlaybookDocument Document { get; set; }
        public virtual TemplateTask Task { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TemplateTaskCategoryType
    {
        public TemplateTaskCategoryType()
        {
            TemplateTaskCategories = new HashSet<TemplateTaskCategory>();
        }

        public int CategoryTypeId { get; set; }
        public string CategoryTypeName { get; set; }

        public virtual ICollection<TemplateTaskCategory> TemplateTaskCategories { get; set; }
    }
}

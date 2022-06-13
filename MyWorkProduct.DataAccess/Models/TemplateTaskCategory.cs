using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class TemplateTaskCategory
    {
        public TemplateTaskCategory()
        {
            InverseParent = new HashSet<TemplateTaskCategory>();
            UserTaskTaskGroups = new HashSet<UserTask>();
            UserTaskTaskSubGroups = new HashSet<UserTask>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryTypeId { get; set; }
        public int? ClientId { get; set; }
        public int? ParentId { get; set; }
        public int SafetyPoints { get; set; }
        public int QualityPoints { get; set; }
        public int EffectivenessPoints { get; set; }
        public int EfficiencyPoints { get; set; }
        public int ZestPoints { get; set; }
        public bool? Archived { get; set; }

        public virtual TemplateTaskCategoryType CategoryType { get; set; }
        public virtual Client Client { get; set; }
        public virtual TemplateTaskCategory Parent { get; set; }
        public virtual ICollection<TemplateTaskCategory> InverseParent { get; set; }
        public virtual ICollection<UserTask> UserTaskTaskGroups { get; set; }
        public virtual ICollection<UserTask> UserTaskTaskSubGroups { get; set; }
    }
}

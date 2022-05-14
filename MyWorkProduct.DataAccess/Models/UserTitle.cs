using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTitle
    {
        public UserTitle()
        {
            ReportTemplates = new HashSet<ReportTemplate>();
            UserTitlePermissions = new HashSet<UserTitlePermission>();
            Users = new HashSet<User>();
        }

        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleDescription { get; set; }
        public int? ClientId { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsAvailable { get; set; }

        public virtual Client Client { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<ReportTemplate> ReportTemplates { get; set; }
        public virtual ICollection<UserTitlePermission> UserTitlePermissions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

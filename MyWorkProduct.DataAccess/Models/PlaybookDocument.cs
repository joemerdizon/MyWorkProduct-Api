using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class PlaybookDocument
    {
        public PlaybookDocument()
        {
            PlaybookFavorites = new HashSet<PlaybookFavorite>();
            PlaybookLinks = new HashSet<PlaybookLink>();
            TemplateTaskPlaybookDocuments = new HashSet<TemplateTaskPlaybookDocument>();
            UserTaskPlaybookDocuments = new HashSet<UserTaskPlaybookDocument>();
        }

        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public int? PlaybookCategoryId { get; set; }
        public string DocumentLink { get; set; }
        public int? DocumentTypeId { get; set; }
        public string DocumentBoxId { get; set; }
        public bool? Active { get; set; }

        public virtual Playbook PlaybookCategory { get; set; }
        public virtual ICollection<PlaybookFavorite> PlaybookFavorites { get; set; }
        public virtual ICollection<PlaybookLink> PlaybookLinks { get; set; }
        public virtual ICollection<TemplateTaskPlaybookDocument> TemplateTaskPlaybookDocuments { get; set; }
        public virtual ICollection<UserTaskPlaybookDocument> UserTaskPlaybookDocuments { get; set; }
    }
}

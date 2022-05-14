using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class UserTaskDocument
    {
        public int DocumentId { get; set; }
        public int? UserId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public string BoxDocumentId { get; set; }
        public int? TaskId { get; set; }
        public DateTime DocumentUploadedOn { get; set; }
        public DateTime LastAccessedOn { get; set; }
        public string ProviderParentFolderId { get; set; }
        public int ProviderStorageAccountId { get; set; }
        public int? TemplateTaskId { get; set; }
        public DateTime? TempTimeStamp { get; set; }
        public int? TempActionItemId { get; set; }

        public virtual UserTask Task { get; set; }
        public virtual TemplateTaskNew TemplateTask { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class PlaybookMaster
    {
        public int PlaybookId { get; set; }
        public string Deaprtment { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DocumentName { get; set; }
        public string Multimedia1 { get; set; }
        public string Multimedia2 { get; set; }
        public string Multimedia3 { get; set; }
        public string Users { get; set; }
        public string Viewers { get; set; }
    }
}

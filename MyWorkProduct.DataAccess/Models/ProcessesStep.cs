using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ProcessesStep
    {
        public int ProcessStepId { get; set; }
        public string ProcessStepName { get; set; }
        public string ProcessStepDescription { get; set; }
        public int? ProcessId { get; set; }
        public bool? ProgressStatus { get; set; }

        public virtual ProcessesMaster Process { get; set; }
    }
}

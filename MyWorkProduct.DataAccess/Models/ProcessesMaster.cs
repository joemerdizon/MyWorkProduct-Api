using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ProcessesMaster
    {
        public ProcessesMaster()
        {
            ProcessesSteps = new HashSet<ProcessesStep>();
        }

        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string ProcessDescription { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ProcessesStep> ProcessesSteps { get; set; }
    }
}

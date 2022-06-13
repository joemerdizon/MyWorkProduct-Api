using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Common.DTO.ReportTemplate
{
    public class ReportTemplateSectionDto
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReportTemplateId { get; set; }
        public int Order { get; set; }
    }
}

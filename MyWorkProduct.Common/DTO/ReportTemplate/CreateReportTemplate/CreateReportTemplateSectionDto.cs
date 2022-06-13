using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Common.DTO.ReportTemplate.CreateReportTemplate
{
    public class CreateReportTemplateSectionDto
    {
        private List<CreateReportTemplateTaskDto> _reportTemplateTasks =
            new List<CreateReportTemplateTaskDto>();      

        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public List<CreateReportTemplateTaskDto> ReportTemplateTasks
        {
            get { return _reportTemplateTasks; }
            set { _reportTemplateTasks = value; }
        }
    }
}

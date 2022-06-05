using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Common.DTO.ReportTemplate
{
    public class ReportTemplateResponseDto
    {
        private List<ReportTemplateDto> _data = new List<ReportTemplateDto>();
        public List<ReportTemplateDto> Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}

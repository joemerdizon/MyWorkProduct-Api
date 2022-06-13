using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Common.DTO.ReportTemplate.CreateReportTemplate
{
    public class CreateReportTemplateRequestDto
    {
        private List<CreateReportTemplateSectionDto> reportTemplateSections = 
            new List<CreateReportTemplateSectionDto>();

        private DateTime _createdDate = DateTime.Now;
        private DateTime _lastUpdatedDate = DateTime.Now;



        [Required]
        [SwaggerSchema(Description = "Report Document Name")]
        public string DocumentName { get; set; }

        [Required]
        [SwaggerSchema(Description = "List of Sections for a Report Template")]
        public List<CreateReportTemplateSectionDto> ReportTemplateSections
        {
            get { return reportTemplateSections; }
            set { reportTemplateSections = value; }
        }

        [SwaggerSchema(ReadOnly = true)]
        public DateTime CreatedDate
        {
            get { return _createdDate; }
        }

        [SwaggerSchema(ReadOnly = true)]
        public DateTime LastUpdatedDate
        {
            get { return _lastUpdatedDate; }
        }



    }
}

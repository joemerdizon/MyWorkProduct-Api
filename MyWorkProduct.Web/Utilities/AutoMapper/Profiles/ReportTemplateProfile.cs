using AutoMapper;
using MyWorkProduct.Common.DTO.ReportTemplate;
using MyWorkProduct.Common.DTO.ReportTemplate.CreateReportTemplate;
using MyWorkProduct.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkProduct.Web.Utilities.AutoMapper.Profiles
{
    public class ReportTemplateProfile: Profile
    {
        public ReportTemplateProfile()
        {
            CreateMap<ReportTemplate, ReportTemplateDto>();

            CreateMap<CreateReportTemplateTaskDto, ReportTemplateTask>();

            CreateMap<CreateReportTemplateSectionDto, ReportTemplateSection>()
                .ForMember(dest => dest.ReportTemplateTasks,
                opt => opt.MapFrom(src => src.ReportTemplateTasks));

            CreateMap<CreateReportTemplateRequestDto, ReportTemplate>()
                .ForMember(dest => dest.ReportTemplateSections,
                opt => opt.MapFrom(src => src.ReportTemplateSections));
        }
    }
}

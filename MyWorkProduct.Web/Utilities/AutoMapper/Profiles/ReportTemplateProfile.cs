using AutoMapper;
using MyWorkProduct.Common.DTO.ReportTemplate;
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
        }
    }
}

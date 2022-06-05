using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyWorkProduct.Common.DTO.ReportTemplate;
using MyWorkProduct.Repository.Interface;
using MyWorkProduct.Web.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkProduct.Web.Controllers.ReportTemplate
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportTempateController : BaseController
    {
        public ReportTempateController(IRepositoryWrapper repositoryWrapper, 
            IConfiguration configuration,
            IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _configuration = configuration;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ReportTemplateResponseDto))]
        public async Task<ActionResult<ReportTemplateResponseDto>> GetAll()
        {
            var reportTemplates = await _repositoryWrapper.ReportTemplateRepository.GetAll();

            var responseData = reportTemplates.Select(entity => _mapper.Map<ReportTemplateDto>(entity)).ToList();

            return StatusCode(StatusCodes.Status200OK, new ReportTemplateResponseDto { Data = responseData });
        }

        [HttpGet]
        [Route("GetById/{reportTemplateId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ReportTemplateDto))]
        public async Task<ActionResult<ReportTemplateDto>> GetById(int reportTemplateId)
        {
            var reportTemplate = await _repositoryWrapper.ReportTemplateRepository.GetById(reportTemplateId);

            var responseData = _mapper.Map<ReportTemplateDto>(reportTemplate);

            return StatusCode(StatusCodes.Status200OK, responseData);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyWorkProduct.Common.DTO.Template;
using MyWorkProduct.Repository.Interface;
using MyWorkProduct.Web.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkProduct.Web.Controllers.Template
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateTaskCategory : BaseController
    {
        public TemplateTaskCategory(IRepositoryWrapper repositoryWrapper, IConfiguration configuration)
        {
            _repositoryWrapper = repositoryWrapper;
            _configuration = configuration;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemplateTaskCategoryResponseDto))]
        public async Task<ActionResult<TemplateTaskCategoryResponseDto>>GetAllTemplateTaskCategory()
        {
            var templateTaskCategories = await _repositoryWrapper.TemplateTaskCategoryRepository.GetAll();

            //Temporary Mapping
            List<TemplateTaskCateoryDto> templateTaskCateoryDtos = new List<TemplateTaskCateoryDto>();
            foreach (var category in templateTaskCategories)
            {
                templateTaskCateoryDtos.Add(new TemplateTaskCateoryDto
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    CategoryType = category.CategoryType.CategoryTypeName,
                    ParentId = category.ParentId
                });
            }

            return StatusCode(StatusCodes.Status200OK, new TemplateTaskCategoryResponseDto { TemplateTaskCategories = templateTaskCateoryDtos });

        }
    }
}

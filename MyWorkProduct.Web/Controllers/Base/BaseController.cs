using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyWorkProduct.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWorkProduct.Web.Controllers.Base
{
    public class BaseController : ControllerBase
    {
        protected IRepositoryWrapper _repositoryWrapper;
        protected IConfiguration _configuration;
        protected IMapper _mapper;
    }
}

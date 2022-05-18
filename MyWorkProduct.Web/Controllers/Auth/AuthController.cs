using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyWorkProduct.Common.DTO.Authenticate;
using MyWorkProduct.Repository.Interface;
using MyWorkProduct.Web.Controllers.Base;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Web.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        protected IRepositoryWrapper _repositoryWrapper;
        protected IConfiguration _configuration;
        public AuthController(IRepositoryWrapper repositoryWrapper, IConfiguration configuration)
        {
            _repositoryWrapper = repositoryWrapper;
            _configuration = configuration;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AuthenticateResponseDto))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<AuthenticateResponseDto>> Authenticate([FromBody] AuthenticateRequestDto authenticateRequestDto)
        {
            var user = await _repositoryWrapper.UserRepository.GetUserByUsername(authenticateRequestDto.Username);

            return StatusCode(StatusCodes.Status200OK, GenerateJwtToken(user.Username));
        }

        protected AuthenticateResponseDto GenerateJwtToken(string userName)
        {
            var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.UtcNow.AddHours(int.Parse(_configuration["JWT:ExpiryHours"])),
                claims: null,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256)
            );

            var authenticateResponseDto = new AuthenticateResponseDto
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token)
            };

            return authenticateResponseDto;
        }

    }
}

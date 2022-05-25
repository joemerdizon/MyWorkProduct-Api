using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyWorkProduct.Common.Constants;
using MyWorkProduct.Common.DTO.Authenticate;
using MyWorkProduct.Common.Helpers;
using MyWorkProduct.DataAccess.Models;
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

            if(ValidateUser(user, authenticateRequestDto.Password))
            {
                var jwtToken = GenerateJwtToken(user);
                return StatusCode(StatusCodes.Status200OK, jwtToken);
            }

            return StatusCode(StatusCodes.Status401Unauthorized, ErrorMessages.INVALID_USER);
        }

        private AuthenticateResponseDto GenerateJwtToken(User user)
        {
            var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var authClaims = GenerateGlaims(user);
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.UtcNow.AddHours(int.Parse(_configuration["JWT:ExpiryHours"])),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256)
            );

            var authenticateResponseDto = new AuthenticateResponseDto
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token)
            };

            return authenticateResponseDto;
        }

        private IList<Claim> GenerateGlaims(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                  new Claim(ClaimTypes.Name, user.Username),
                  new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                  new Claim(ClaimTypes.Role, user.Role.RoleDescription),
                  new Claim(ClaimTypes.GroupSid, user.RoleId.ToString())
            };

            return claims;
        }

        private bool ValidateUser(User user, string enteredPassword)
        {
            bool isValidUser = false;

            bool isPasswordCorrect = AuthenticateHelper.VerifyHashedString(user.Password, enteredPassword);
            if (isPasswordCorrect)
                isValidUser = true;

            return isValidUser;
        }
    }
}

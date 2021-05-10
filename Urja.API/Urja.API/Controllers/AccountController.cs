using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Urja.Model.Data;
using Urja.Model.DTO;
using Urja.Repository.Account;
using Urja.Utility.Helper;
using Urja.Utility.Services.Constant;

namespace Urja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAccountRepository _accountRepository;
        private readonly IStringConstant _iStringConstant;

        public AccountController(IConfiguration configuration, IAccountRepository accountRepository, IStringConstant iStringConstant)
        {
            _configuration = configuration;
            _accountRepository = accountRepository;
            _iStringConstant = iStringConstant;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<BaseTokenModel> LoginAsync([FromBody] LoginDTO loginDTO)
        {
            
            BaseTokenModel baseTokenModel = new BaseTokenModel();
            try
            {
                if (loginDTO == null)
                {
                    baseTokenModel.Message = _iStringConstant.InvalidRequest;
                    baseTokenModel.StatusCode = (int)EnumList.ResponseType.Error;
                }
                else
                {
                    BaseResponseModel responseModel = await _accountRepository.ValidateUserAsync(loginDTO);
                    if (responseModel.StatusCode == (int)EnumList.ResponseType.Success)
                    {
                        UserTokenDTO userData = (UserTokenDTO)responseModel.Data;

                        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KeyForSignInMaxlinkDemo@1234"));
                        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                        //For calime which we get the data from accessToken
                        var claims = new[] {
                            new Claim("FirstName",userData.FirstName),
                            new Claim("LastName",userData.LastName),
                            new Claim("MobileNumber",userData.MobileNumber),
                            new Claim(ClaimTypes.NameIdentifier, userData.Id.ToString()),
                            new Claim("Email", userData.Email)
                            };

                        //Create token based on our claims and signingCredentials
                        var tokeOptions = new JwtSecurityToken(
                            issuer: _configuration["Jwt:ValidIssuer"],
                            audience: _configuration["Jwt:ValidIssuer"],
                            claims: claims,
                            expires: DateTime.Now.AddDays(1),
                            signingCredentials: signingCredentials
                        );
                        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                        baseTokenModel.Id = userData.Id.ToString();
                        baseTokenModel.FirstName = userData.FirstName;
                        baseTokenModel.LastName = userData.LastName;
                        baseTokenModel.Email = userData.Email;
                        baseTokenModel.Address = userData.Address;
                        baseTokenModel.MobileNumber = userData.MobileNumber;
                        baseTokenModel.CityName = userData.CityName;
                        baseTokenModel.ZipCode = userData.ZipCode;
                        baseTokenModel.SocialSecurityNumber = userData.SocialSecurityNumber;
                        baseTokenModel.AccessToken = tokenString;
                        baseTokenModel.Message = _iStringConstant.LoginSuccessfull;
                        baseTokenModel.StatusCode = Convert.ToInt32(EnumList.ResponseType.Success);
                    }
                    else
                    {
                        baseTokenModel.Message = responseModel.Message;
                        baseTokenModel.StatusCode = responseModel.StatusCode;
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                baseTokenModel.Message = ex.Message;
                baseTokenModel.StatusCode = Convert.ToInt32(EnumList.ResponseType.Exception);
            }
            return baseTokenModel;

        }

        [HttpPost]
        [Route("Signup")]
        public async Task<BaseResponseModel> SignupAsync(UserDetailDTO userDetail)
        {
            try
            {
                return await _accountRepository.SignUpAsync(userDetail);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                return StatusBuilder.ResponseFailStatus(null, ex.Message);
            }
        }

        


    }
}

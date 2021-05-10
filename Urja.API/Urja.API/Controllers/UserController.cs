using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Urja.Model.Data;
using Urja.Model.DTO;
using Urja.Repository.Account;
using Urja.Repository.User;
using Urja.Utility.Helper;

namespace Urja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        //private readonly IAccountRepository _accountRepository;

        public UserController(IConfiguration configuration,IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
           // _accountRepository = accountRepository;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/UserDetail/GetUsers")]
        public IEnumerable<UserDetail> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/UserDetail/AddUsers")]
        public UserDetail AddUsers(UserDetail userDetail)
        {
            return _userRepository.AddUsers(userDetail);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/UserDetail/UpdateUsers")]
        public UserDetail UpdateUsers(UserDetail userDetail)
        {
            return _userRepository.UpdateUsers(userDetail);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/UserDetail/DeleteUsers")]
        public UserDetail DeleteUsers(int Id)
        {
            return _userRepository.DeleteUsers(Id);
        }

        


    }
}

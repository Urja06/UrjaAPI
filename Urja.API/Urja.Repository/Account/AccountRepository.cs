using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urja.Model.Data;
using Urja.Model.DTO;
using Urja.Utility.Helper;
using Urja.Utility.Services.Constant;

//project starts 
namespace Urja.Repository.Account
{
    public class AccountRepository
    {
        private readonly IConfiguration _config;
        private readonly IStringConstant _iStringConstant;
        private object dataSet;

        public AccountRepository(IConfiguration config,IStringConstant iStringConstant)
            
        {
            _config = config;
            _iStringConstant = iStringConstant;

        }

        

        
    }
}

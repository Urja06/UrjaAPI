using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Urja.Model.Data;
using Urja.Model.DTO;
using Urja.Utility.Helper;

namespace Urja.Repository.Account
{
    public interface IAccountRepository
    {
        Task<BaseResponseModel> ValidateUserAsync(LoginDTO loginDTO);

        Task<BaseResponseModel> SignUpAsync(UserDetailDTO userDetailDTO);

    }
}

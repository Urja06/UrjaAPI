using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Urja.Model.Data;
using Urja.Model.DTO;
using Urja.Utility.Helper;

namespace Urja.Repository.User
{
    public interface IUserRepository
    {
        IEnumerable<UserDetail> GetUsers();
        UserDetail AddUsers(UserDetail userDetail);
        UserDetail UpdateUsers(UserDetail userDetail);
        UserDetail DeleteUsers(int Id);
        
    }
}

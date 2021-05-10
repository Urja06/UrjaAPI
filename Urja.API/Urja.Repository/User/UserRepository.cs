using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urja.Model.Data;
using Urja.Model.DTO;
using Urja.Utility.Helper;


namespace Urja.Repository.User
{
    public class UserRepository:IUserRepository
    {
        UrjaContext dbContext;

        public UserRepository(UrjaContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<UserDetail> GetUsers()
        {
            var udetails = dbContext.UserDetails.ToList();
            return udetails;
        }

        public UserDetail AddUsers(UserDetail userDetail)
        {
            if (userDetail != null)
            {
                dbContext.UserDetails.Add(userDetail);
                dbContext.SaveChanges();
                return userDetail;
            }
            return null;
        }

        public UserDetail UpdateUsers(UserDetail userDetail)
        {
            dbContext.Entry(userDetail).State = EntityState.Modified;
            dbContext.SaveChanges();
            return userDetail;
        }

        public UserDetail DeleteUsers(int Id)
        {
            var udetails = dbContext.UserDetails.FirstOrDefault(x => x.Id == Id);
            dbContext.Entry(udetails).State = EntityState.Modified;
            dbContext.SaveChanges();
            return udetails;
        }
    }
    
}

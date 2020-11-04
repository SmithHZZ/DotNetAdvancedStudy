using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19_soa_webservice.Models
{
    public class UserService : IUserService
    {
        public User GetUserById(int id)
        {
            return new User() { Id = id };
        }
    }
}
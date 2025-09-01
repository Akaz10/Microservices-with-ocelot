using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.API.Infrastructure;
using User.API.Models;

namespace User.API.Services
{
    public class UserService : IUserService
    {
        public UserDTO GetUserById(int id)
        {
            return new UserDTO()
            {
                Id = id,
                FirstName = "Onur",
                LastName = "Özdemir",
            };
        }
    }
}

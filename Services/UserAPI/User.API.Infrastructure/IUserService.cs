using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.API.Models;

namespace User.API.Infrastructure
{
    public interface IUserService
    {
        public UserDTO GetUserById(int id);
    }
}

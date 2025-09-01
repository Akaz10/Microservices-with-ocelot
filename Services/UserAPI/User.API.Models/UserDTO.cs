using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.API.Models
{
    public class UserDTO
    {
        public  int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public String FullName => $"{FirstName} {LastName}";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETArandDomain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { 

        }

        public User(string Name, string Email, string Password)
        {
            this.Id = -1;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
        }
    }
}

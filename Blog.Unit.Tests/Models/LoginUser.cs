using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Unit.Tests.Models
{
    public class LoginUser
    {
        private string email;
        private string password;

        public LoginUser(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }

}

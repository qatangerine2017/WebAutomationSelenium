using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Unit.Tests.Models
{
    public class RegisterUser
    {
        private string email;
        private string fullName;
        private string password;
        private string confirmPassword;

        public RegisterUser(String email,
                            String fullName,
                            String password,
                            String confirmPassword)
        {
            this.email = email;
            this.fullName = fullName;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string ConfirmPassword
        {
            get { return this.confirmPassword; }
            set { this.confirmPassword = value; }
        }
    }
}

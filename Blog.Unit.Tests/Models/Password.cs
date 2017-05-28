using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Unit.Tests.Models
{
    public class Password
    {
        private string currentPassword;
        private string newPassword;
        private string confirmNewPassword;

        public Password(string currentPassword, string newPassword, string confirmNewPassword)
        {
            this.currentPassword = currentPassword;
            this.newPassword = newPassword;
            this.confirmNewPassword = confirmNewPassword;
        }

        public string CurrentPassword
        {
            get { return this.currentPassword; }
            set { this.currentPassword = value; }
        }
        public string NewPassword
        {
            get { return this.newPassword; }
            set { this.newPassword = value; }
        }
        public string ConfirmNewPassword
        {
            get { return this.confirmNewPassword; }
            set { this.confirmNewPassword = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.Unit.Tests.Models;

namespace UnitTests.Pages.ChangePasswordPage
{
    public partial class ChangePasswordPage : BasePage
    {
        public ChangePasswordPage(IWebDriver driver) : base(driver)
        {
        }
        public void ChangePassword(Password password)
        {
            this.RegistrateEmail.Click();
            this.ChangeYourPasswordButton.Click();
            Type(this.CurrentPassword, password.CurrentPassword);
            Type(this.NewPassword, password.NewPassword);
            Type(this.ConfirmNewPassword, password.ConfirmNewPassword);
            this.ChangePasswordButton.Click();
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text ?? string.Empty);
        }
    }
}

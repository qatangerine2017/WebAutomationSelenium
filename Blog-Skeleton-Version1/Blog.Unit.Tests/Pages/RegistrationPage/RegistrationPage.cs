using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.Unit.Tests.Models;

namespace UnitTests.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public string URL
        {
            get
            {
                return base.Url + "Register/";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }

        public void FillRegistrationForm(RegisterUser user)
        {
            Type(this.FullName, user.FullName);
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.RegisterButton.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text ?? string.Empty);
        }
    }
}

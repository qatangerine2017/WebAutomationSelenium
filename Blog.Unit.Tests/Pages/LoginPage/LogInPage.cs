using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.Unit.Tests.Models;

namespace UnitTests.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Login");
        }

        public void FillLoginForm(LoginUser user)
        {
            this.LoginButton.Click();
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            this.LogIn.Click();
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            this.LogIn.Click();
            //this.SubmitButton.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

    }
}

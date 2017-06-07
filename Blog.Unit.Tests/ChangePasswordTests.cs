using Blog.Unit.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.ChangePasswordPage;
using UnitTests.Pages.RegistrationPage;

namespace Blog.Unit.Tests
{
    [TestFixture]
    public class ChangePasswordTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }
        [Test]
        [Author("Hristina Mineva")]
        public void CheckThePasswordIsChanged()
        {
            var email = "Katy" + DateTime.Now.Ticks + "@abv.bg";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Katy Perry", "0123456789", "0123456789");
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var changePasswordPage = new ChangePasswordPage(this.driver);
            var newPassword = new Password("0123456789", "9876543210", "9876543210");
            changePasswordPage.ChangePassword(newPassword);

            changePasswordPage.AssertPasswordIsChange("Your password has been changed.");
        }
    }
}

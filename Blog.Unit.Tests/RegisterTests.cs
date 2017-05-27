using Blog.Unit.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using UnitTests.Pages.RegistrationPage;

namespace Blog.Unit.Tests
{
    [TestFixture]
    public class RegisterTests
        {
            private IWebDriver driver;

            [SetUp]
            public void Init()
            {
                this.driver = BrowserHost.Instance.Application.Browser;
                this.driver.Manage().Window.Maximize();
            }

            [TearDown]
            public void CleanUp()
            {
                this.driver.Quit();
            }

        [Test]
        [Author("Boriana Avramova")]
        public void RegisterWithoutData()
        {
            var registrationPage = new RegistrationPage(this.driver);
            RegisterUser user = new RegisterUser("",
                                                 "",
                                                 "",
                                                 "");

            registrationPage.FillRegistrationForm(user);

            registrationPage.AssertErrorMessageForEmail("The Email field is required.");
            registrationPage.AssertErrorMessageForFullName("The Full Name field is required.");
            registrationPage.AssertErrorMessageForPassword("The Password field is required.");
        }

        [Test]
        [Author("Boriana Avramova")]
        public void RegisterWithIncorrectMail()
        {
            var registrationPage = new RegistrationPage(this.driver);
            RegisterUser user = new RegisterUser("a",
                                                 "",
                                                 "",
                                                 "");

            registrationPage.FillRegistrationForm(user);

            registrationPage.AssertErrorMessageForEmail("The Email field is not a valid e-mail address.");
            registrationPage.AssertErrorMessageForFullName("The Full Name field is required.");
            registrationPage.AssertErrorMessageForPassword("The Password field is required.");
        }

        [Test]
        [Author("Boriana Avramova")]
        public void RegisterWithPasswordsMismatch()
        {
            var registrationPage = new RegistrationPage(this.driver);
            RegisterUser user = new RegisterUser("a@a.a",
                                                 "B A",
                                                 "a",
                                                 "");

            registrationPage.FillRegistrationForm(user);

            registrationPage.AssertErrorMessageForPasswordMismatch("The password and confirmation password do not match.");
        }

        [Test]
        [Author("Boriana Avramova")]
        public void RegisterWithCorrectData()
        {
            var registrationPage = new RegistrationPage(this.driver);
            RegisterUser user = new RegisterUser("a" + DateTime.Now.Ticks + "@a.a",
                                                 "B A",
                                                 "a",
                                                 "a");

            registrationPage.FillRegistrationForm(user);

            registrationPage.AssesrtSuccessMessage("Hello");
        }
    }
}

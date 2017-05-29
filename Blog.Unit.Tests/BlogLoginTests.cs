using Blog.Unit.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using UnitTests.Pages.HomePage;
using UnitTests.Pages.LoginPage;
using UnitTests.Pages.RegistrationPage;

namespace Blog.Unit.Tests
{
    [TestFixture]
    public class BlogLoginTests
    {
        IWebDriver driver = BrowserHost.Instance.Application.Browser;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        [Test]
        [Author("Adelina Yanakieva")]
        public void CheckIsLoggedInWithValidData()
        {
            var email = "Lili" + DateTime.Now.Ticks + "@mail.bg";
            var password = "0123456789";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Lili Ivanova", password, password);
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser); 

            var loginPage = new LoginPage(this.driver);
            loginPage.LogOffButton.Click();   // ok
            loginPage.LoginButton.Click();
            var loginUser = new LoginUser(email, password);
            loginPage.FillLoginForm(loginUser);

            loginPage.AssertSuccessMessageLogin("Hello");
        }

        [Test]
        [Author("Adelina Yanakieva")]
        public void CheckIsLoggedInWithInvalidPassword()
        {
            var email = "Lili" + DateTime.Now.Ticks + "@mail.bg";
            var password = "0123456789";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Lili Ivanova", password, password);
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var loginPage = new LoginPage(this.driver);
            loginPage.LogOffButton.Click();   
            loginPage.LoginButton.Click();
            var loginUser = new LoginUser(email, password + "FALSE");
            loginPage.FillLoginForm(loginUser);

            loginPage.AssertErrorMessageForInvalidLoginData("Invalid login attempt.");
        }

        [Test]
        [Author("Adelina Yanakieva")]
        public void CheckIsLoggedInWithInvalidEmail()
        {
            var email = "Lili" + DateTime.Now.Ticks + "@mail.bg";
            var password = "0123456789";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Lili Ivanova", password, password);
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var loginPage = new LoginPage(this.driver);
            loginPage.LogOffButton.Click();
            loginPage.LoginButton.Click();
            var loginUser = new LoginUser(email + "FALSE", password);
            loginPage.FillLoginForm(loginUser);

            loginPage.AssertErrorMessageForInvalidLoginData("Invalid login attempt.");
        }

    }
}

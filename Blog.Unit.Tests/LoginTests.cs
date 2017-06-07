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
    public class LoginTests
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
           // this.driver.Quit();
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        // -------REGISTER--------
        // 1. Navigate to home page
        // 2. Navigate/click on Register
        // 3. Fill register form
        // 4. Click Register button
        //     4.1. Check success message?
        // -------LOG OFF--------
        // 5. Click Log off button
        //     4.1. Check home page loaded
        // -------LOGIN--------
        // 6. Click Login button
        // 7. Fill Login form
        // 8. Click Login button
        // 9. Check for success message

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

            loginPage.AssertSuccessMessageLogin("Hello " + email + "!");
        }

        [Test]
        [Author("Adelina Yanakieva")]
        public void CheckIsLoggedInWithInvalidPassword()
        {
            var email = "Lili" + DateTime.Now.Minute + "@mail.bg";
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
            var email = "Lili" + DateTime.Now.Minute + "@mail.bg";
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

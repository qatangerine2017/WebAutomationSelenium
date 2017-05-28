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
        //public IWebDriver driver;
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

        // -------REGISTER--------
        // 1. Navigate to home page
        // 2. Navigate/click on Register
        // 3. Fill register form
        // 4. Click Register bitton
        //     4.1. Check success message?
        // -------LOG OFF--------
        // 5. Click Log off button
        //     4.1. Check home page loaded
        // -------LOGIN--------
        // 6. Click Login button
        // 7. Fill Login form
        // 8. Click Login button
        // 9. Check for success message

        public void NavigateToLoginPage()
        {
            var email = "Lili" + DateTime.Now.Ticks + "@mail.bg";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Lili Ivanova", "0123456789", "0123456789");
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            // var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            // PageFactory.InitElements(this.driver, homePage);

            //homePage.NavigateTo();
            // homePage.RegisterButton.Click();

            // loginPage.AssertLoginPageIsOpen("Registration");
        }

    }
}

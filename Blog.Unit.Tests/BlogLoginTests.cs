using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.HomePage;
using UnitTests.Pages.LoginPage;

namespace Blog.Unit.Tests
{
    [TestFixture]
    public class BlogLoginTests
    {
        public IWebDriver driver;

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

        public void NavigateToRegisterPage()
        {
            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            PageFactory.InitElements(this.driver, homePage);

            homePage.NavigateTo();
           // homePage.RegisterButton.Click();

           // loginPage.AssertLoginPageIsOpen("Registration");
        }
    }
}

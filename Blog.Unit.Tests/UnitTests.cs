using Blog.Unit.Tests.Models;
using Blog.Unit.Tests.Pages.ReviewingArticle;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.RegistrationPage;

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.driver.Manage().Window.Maximize();
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        [Test]
        public void CheckSiteLoad()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.Navigate().GoToUrl("http://localhost:60634/Article/List");

            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
        [Test]
        public void CheckArticleIsCreated()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            var email = "Katy" + DateTime.Now.Ticks + "@abv.bg";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Katy Perry", "0123456789", "0123456789");
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var createdArticle = new ReviewingArticlePage(this.driver);
            if (createdArticle.EmptyPage.Displayed)
            {
                return;
            }
            else
            {
                createdArticle.AssertArticleIsCreated("The article was created!");
            }
        }
    }
}

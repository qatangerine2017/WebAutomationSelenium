using Blog.Unit.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using UnitTests.Pages.CreateArticlePage;
using UnitTests.Pages.RegistrationPage;

namespace Blog.Unit.Tests
{
    class CreateArticleTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = BrowserHost.Instance.Application.Browser;  //new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            //  this.driver.Close();
            //  this.driver.Quit();
        }

        [Test]
        [Author("Viara Vasileva")]
        public void CreateNewArticleCheck()
        {
            var email = "Nadeto" + DateTime.Now.Ticks + "@abv.bg";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Nadeto Petrova", "petrovanadeto", "petrovanadeto");
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var createdArticle = new CreateArticlePage(this.driver);

            var newArticle = new Article("Yep!", "The first Article is here!");

            createdArticle.CreateArticle(newArticle);

            createdArticle.AssertArticleIsCreated("The new article is visible!");
        }
    }
}

using Blog.Unit.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.CreateArticlePage;
using UnitTests.Pages.DeleteArticlePage;
using UnitTests.Pages.EditArticlePage;
using UnitTests.Pages.LoginPage;
using UnitTests.Pages.RegistrationPage;

namespace Blog.Unit.Tests
{
    [TestFixture]
    public class EditArticleTests
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
        public void CheckArticleIsEdit()
        {
            var email = "Katy" + DateTime.Now.Ticks + "@abv.bg";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Katy Perry", "0123456789", "0123456789");
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var createdArticle = new CreateArticlePage(this.driver);

            var newArticle = new Article("Hello!", "I am new article!");

            createdArticle.CreateArticle(newArticle);
            createdArticle.LogOffButton.Click();

            var logForm = new LoginPage(this.driver);
            var loginUser = new LoginUser(email, "0123456789");
            logForm.FillLoginForm(loginUser);

            var editArticlePage = new EditArticlePage(this.driver);
            var editArticle = new EditArticle("Hello World!", "I am new article again!");
            editArticlePage.EditArticle(editArticle);

            editArticlePage.AssertArticleTitleIsEdit("Hello World!");
            editArticlePage.AssertArticleContentIsEdit("I am new article again!");

            var existingArticle = new DeleteArticlePage(this.driver);
            existingArticle.NavigateTo();

            existingArticle.CheckForExistingArticle(newArticle);            
        }
    }
}
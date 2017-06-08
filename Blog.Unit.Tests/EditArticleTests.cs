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
            EditArticlePage editArticlePage = new EditArticlePage(this.driver);
            CreateArticlePage createArticlePage = new CreateArticlePage(this.driver);
            RegistrationPage registrationPage = new RegistrationPage(this.driver);
            LoginPage loginPage = new LoginPage(this.driver);
            var email = "Test" + DateTime.Now.Hour + "@mail.bg";
            var password = "123456789";
            var name = "Test";
            RegisterUser user = new RegisterUser(email, name, password, password);
            LoginUser loginUser = new LoginUser(email, password);
            var title = "Article Title!";
            var content = "Article Content!";
            Article article = new Article(title, content);
            var editTitle = "Article Title Changed!";
            var editContent = "Article Content Changed!";
            EditArticle editArticle = new EditArticle(editTitle, editContent);
            editArticlePage.NavigateTo();
            if (editArticlePage.CreatedArticle.Displayed)
            {
                loginPage.FillLoginForm(loginUser);
                editArticlePage.EditArticle(editArticle);
                editArticlePage.AssertArticleTitleIsEdit("Article Title Changed!");
                editArticlePage.AssertArticleContentIsEdit("Article Content Changed!");
            }
            else
            {
                registrationPage.FillRegistrationForm(user);
                createArticlePage.CreateArticle(article);
                editArticlePage.EditArticle(editArticle);
                editArticlePage.AssertArticleTitleIsEdit("Article Title Changed!");
                editArticlePage.AssertArticleContentIsEdit("Article Content Changed!");
            }
        }
    }
}
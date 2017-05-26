using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using UnitTests.Pages.DeleteArticlePage;

namespace Blog.Unit.Tests
{
    [TestFixture]
    public class DeleteArticle
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
        public void CheckArticleIsDeleted()
        {
            var article = new DeleteArticlePage(this.driver);
            if (article.EmptyPage.Displayed)
            {
                article.AssertTheBlogIsEmpty("There aren't created articles!");
            }
            else
            {
                article.DeleteButton.Click();
                article.AssertTheArticleIsNotDeleted("The article is NOT deleted!");
            }
        }
    }
}

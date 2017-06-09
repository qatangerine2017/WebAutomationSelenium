using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.Unit.Tests.Models;

namespace UnitTests.Pages.CreateArticlePage
{
    public partial class CreateArticlePage : BasePage
    {
        public CreateArticlePage(IWebDriver driver) : base(driver)
        {
        }

        public void CreateArticle(Article article)
        {
            this.CreateButton.Click();
            Type(this.Title, article.Title);
            Type(this.Content, article.Content);
            this.CreateArticleButton.Click();

        }
        public void DeleteArticle(Article article)
        {
            this.CreatedArticle.Click();
            this.DeleteButton.Click();
            this.Delete.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text ?? string.Empty);
        }
    }
}

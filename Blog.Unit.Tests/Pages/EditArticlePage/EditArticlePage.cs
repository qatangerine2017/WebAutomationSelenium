using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Blog.Unit.Tests.Models;

namespace UnitTests.Pages.EditArticlePage
{
    public partial class EditArticlePage : BasePage
    {
        public EditArticlePage(IWebDriver driver) : base(driver)
        {
        }
        public string URL
        {
            get
            {
                return base.Url + "Register/";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }

        public void EditArticle(EditArticle editArticle)
        {
            this.CreatedArticle.Click();
            this.EditButton.Click();
            Type(this.Title, editArticle.Title);
            Type(this.Content, editArticle.Content);
            this.Edit.Click();
        }

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text ?? string.Empty);
        }

    }
}
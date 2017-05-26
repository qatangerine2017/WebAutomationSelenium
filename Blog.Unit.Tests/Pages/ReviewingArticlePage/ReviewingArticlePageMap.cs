using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Unit.Tests.Pages.ReviewingArticle
{
    public partial class ReviewingArticlePage
    {
        public IWebElement EmptyPage
        {
            get
            {
                var xpath = "/html/body/div[2]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement CreatedArticle
        {
            get
            {
                var xpath = "/html/body/div[2]/div/article/header/h2";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
    }
}

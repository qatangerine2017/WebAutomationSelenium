using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.EditArticlePage
{
    public partial class EditArticlePage
    {
        public IWebElement CreatedArticle
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/div/article/header/h2/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement EditButton
        {
            get
            {
                var xpath = "/html/body/div[2]/div/article/footer/a[1]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Title
        {
            get
            {
                var xpath = "//*[@id=\"Title\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Content
        {
            get
            {
                var xpath = "//*[@id=\"Content\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Edit
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[4]/div/input";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement EditTitle
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/div/article/header/h2/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement EditContent
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/div/article/p";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
    }
}
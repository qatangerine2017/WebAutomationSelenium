using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.CreateArticlePage
{
    public partial class CreateArticlePage
    {
        public IWebElement CreateButton
        {
            get
            {
                var xpath = "//*[@id=\"logoutForm\"]/ul/li[1]/a";
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

        public IWebElement CreateArticleButton
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[4]/div/input";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement NewArticle
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/div";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement LogOffButton
        {
            get
            {
                var xpath = "//*[@id=\"logoutForm\"]/ul/li[3]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement ErrorMessageForArticleWithoutTitle
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[1]/ul/li";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement ErrorMessageForArticleWithoutContent
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[1]/ul/li";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement CombinationOfErrorMessagesWithoutTitle
        { 
            get
            {
                             
                var xpath = "/html/body/div[2]/div/div/form/div[1]/ul/li[1]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }        
        }

        public IWebElement CombinationOfErrorMessagesWithoutContent
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[1]/ul/li[2]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement TitleField => this.Driver.FindElement(By.XPath("html/body/div[2]/div/div/div/article/header/h2/a"));

        public IWebElement ContentField => this.Driver.FindElement(By.XPath("html/body/div[2]/div/div/div/article/p"));
    }
}

﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.DeleteArticlePage
{
    public partial class DeleteArticlePage
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
        public IWebElement DeleteButton
        {
            get
            {
                var xpath = "/html/body/div[2]/div/article/footer/a[2]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement ErrorMessageForDeletingArticle
        {
            get
            {
                var xpath = "//*[@id=\"content\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

    }
}
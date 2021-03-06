﻿using Blog.Unit.Tests.Models;
using Blog.Unit.Tests.Pages.ReviewingArticle;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using UnitTests.Pages.RegistrationPage;

namespace SiteLoadTests
{
    [TestFixture]
    public class SiteLoadTests
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
             this.driver = new ChromeDriver();
          //  IWebDriver driver = BrowserHost.Instance.Application.Browser;
            this.driver.Manage().Window.Maximize();
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        [Test]
        [Author("Viara Vasileva")]
        public void SiteLoadCheck()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.Navigate().GoToUrl("http://localhost:60634/Article/List");

            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
    }
}

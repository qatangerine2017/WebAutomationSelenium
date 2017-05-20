using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IntegrationTests
{
    [TestFixture]
    public class IntegrationTests
    {
        [Test]
        public void CheckSiteLoad()
        {
            IWebDriver driver = Host.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            driver.Navigate().GoToUrl(@"http://localhost:60634/Article/List");
            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));
            NUnit.Framework.Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
    }
}

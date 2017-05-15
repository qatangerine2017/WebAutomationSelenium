using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using IntegrationTests.Models;
using OpenQA.Selenium.Chrome;
using IntegrationTests.Pages.RegistrationPage;

namespace IntegrationTests
{
    [TestFixture]
    public class BlogIntegrationTests
    {
        public IWebDriver driver;
        private RegisterUser registrationUser;
        private RegisterUser user;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        //[TearDown]
        //public void CleanUp()
        //{
        //    //if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        //    //{
        //    //    string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
        //    //    if (File.Exists(filename))
        //    //    {
        //    //        File.Delete(filename);
        //    //    }
        //    //    File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        " + TestContext.CurrentContext.WorkDirectory + "            " + TestContext.CurrentContext.Result.PassCount);

        //    //    var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
        //    //    screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
        //    //}

        //    this.driver.Quit();
        //}

        [Test, Property("RegistrationFormTests", 1)]
        public void RegisterWithOutData()
        {
            var regPage = new RegistrationPage(this.driver);
            RegisterUser user = new RegisterUser("",
                                                 "",
                                                 "",
                                                 "");

            driver.Navigate().GoToUrl(@"http://localhost:60634/Article/List/Register");
            regPage.FillRegistrationForm(user);

            regPage.AssertErrorMessages("This field is required");
        }

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

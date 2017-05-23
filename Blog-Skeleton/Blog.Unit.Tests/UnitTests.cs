using Blog.Unit.Tests.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.RegistrationPage;

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
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
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.Navigate().GoToUrl("http://localhost:60634/Article/List");

            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
    }
}

using Blog.Unit.Tests.Models;
using Blog.Unit.Tests.Pages.ReviewingArticles;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.DeleteArticlePage;
using UnitTests.Pages.LoginPage;
using UnitTests.Pages.RegistrationPage;


namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        public IWebDriver driver;
       // private RegisterUser registrationUser;
      //  private RegisterUser user;

        [SetUp]
        public void Init()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
        //    if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        //    {
        //        string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
        //        if (File.Exists(filename))
        //        {
        //            File.Delete(filename);
        //        }
        //        File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        " + TestContext.CurrentContext.WorkDirectory + "            " + TestContext.CurrentContext.Result.PassCount);

        //        var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
        //        screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
        //    }

           this.driver.Quit();
        }

        [Test]
        [Property("RegistrationFormTests", 1)]
        public void RegisterWithOutData()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.Navigate().GoToUrl("http://localhost:60634/Article/List");

            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
        [Test]
        public void RegistrationNewUser()
        {
            var registrationPage = new RegistrationPage(this.driver);
            var email = "Katy" + DateTime.Now.Ticks + "@abv.bg";
            registrationPage.NavigateTo();
            var registrationUser = new RegisterUser(email, "Katy Perry", "0123456789", "0123456789");

            registrationPage.FillRegistrationForm(registrationUser);

            registrationPage.AssertRegistrateMessage("Hello" + " " + email + "!");           
        }
        [Test]
        public void CheckArticleIsCreated()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            var email = "Katy" + DateTime.Now.Ticks + "@abv.bg";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Katy Perry", "0123456789", "0123456789");
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var createdArticle = new ReviewingArticlesPage(this.driver);
            if(createdArticle.EmptyPage.Displayed)
            {
                return;
            }
            else
            {
                createdArticle.AssertArticleIsCreated("The article was created!");
            }
        }
        [Test]
        public void CheckArticleIsDeleted()
        {
            var article = new DeleteArticlePage(this.driver);
            if (article.EmptyPage.Displayed)
            {
                article.AssertTheBlogIsEmpty("There aren't created articles!");
            }
            else
            {
                article.DeleteButton.Click();
                article.AssertTheArticleIsNotDeleted("The article is NOT deleted!");
            }
        }
    }
}

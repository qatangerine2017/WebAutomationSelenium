using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.LoginPage
{
    public partial class LoginPage
    {
        public IWebElement LoginButton
        {
            get
            {
                var id = "loginLink";
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id(id)));
                return this.Driver.FindElement(By.Id(id));
            }
        }

        public IWebElement Email
        {
            get
            {
                var xpath = "//*[@id=\"Email\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement Password
        {
            get
            {
                var xpath = "//*[@id=\"Password\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement LogIn
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[4]/div/input";
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


        public IWebElement SuccessMessageLogin
        {
            get
            {
                var xpath = "//*[@id=\"logoutForm\"]/ul/li[2]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement ErrorMessageForInvalidLoginData
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[1]/ul/li";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
    }
}


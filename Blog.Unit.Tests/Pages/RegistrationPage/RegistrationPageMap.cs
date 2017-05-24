using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public IWebElement RegistrationButton
        {
            get
            {
                var xpath = "//*[@id=\"registerLink\"]";
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Email
        {
            get
            {
                return this.Driver.FindElement(By.Name("Email"));
            }
        }

        public IWebElement FullName
        {
            get
            {
                return this.Driver.FindElement(By.Name("FullName"));
            }
        }

        public IWebElement Password
        {
            get
            {
                return this.Driver.FindElement(By.Name("Password"));
            }
        }

        public IWebElement ConfirmPassword
        {
            get
            {
                return this.Driver.FindElement(By.Name("ConfirmPassword"));
            }
        }

        public IWebElement RegisterButton
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[6]/div/input";
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement SuccessMessage
        {
            get
            {
                var xpath = "//*[@id=\"logoutForm\"]/ul/li[2]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }

        public IWebElement ErrorMessages
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[1]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }            
        }
        public IWebElement RegistrateMessage
        {
            get
            {
                var xpath = "//*[@id=\"logoutForm\"]/ul/li[2]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
    }
}

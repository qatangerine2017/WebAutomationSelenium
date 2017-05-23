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
                return this.Driver.FindElement(By.Name("Register"));
            }
        }

        public IWebElement SuccessMessage
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));
            }
        }

        public IWebElement ErrorMessages
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]"));
            }
        }
    }
}

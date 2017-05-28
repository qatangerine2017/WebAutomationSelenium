using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.ChangePasswordPage
{
    public partial class ChangePasswordPage
    {
        public IWebElement RegistrateEmail
        {
            get
            {
                var xpath = "//*[@id=\"logoutForm\"]/ul/li[2]/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement ChangeYourPasswordButton
        {
            get
            {
                var xpath = "/html/body/div[2]/div/dl/dd/a";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement CurrentPassword
        {
            get
            {
                var xpath = "//*[@id=\"OldPassword\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement NewPassword
        {
            get
            {
                var xpath = "//*[@id=\"NewPassword\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement ConfirmNewPassword
        {
            get
            {
                var xpath = "//*[@id=\"ConfirmPassword\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement ChangePasswordButton
        {
            get
            {
                var xpath = "/html/body/div[2]/div/div/form/div[5]/div/input";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement SuccessMessage
        {
            get
            {
                var xpath = "/html/body/div[2]/p";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
    }
}

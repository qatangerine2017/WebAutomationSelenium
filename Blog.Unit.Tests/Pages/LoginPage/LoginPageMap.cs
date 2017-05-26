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
        public IWebElement Email
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
            }
        }

        public IWebElement Password
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            }
        }


        public IWebElement SuccessMessage
        {
            get
            {
                //  //*[@id="logoutForm"]/ul/li[2]/a 
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));
            }
        }

        // public IWebElement ErrorMessageForInvalidEmail
        // {
        //     get
        //     {
        //         this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span")));
        //         return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
        //     }
        // }

    }
}

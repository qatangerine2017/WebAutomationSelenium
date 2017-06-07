using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public IWebElement RegirstratonButton
        {
            get
            {
                return this.Driver.FindElement(By.PartialLinkText("Register"));
            }
        }
        /* public HomePage(IWebDriver driver)
             : base(driver)
         {
         }

         public string URL
         {
             get
             {
                 return Url;
             }
         }

         public void NavigateTo()
         {
             this.Driver.Navigate().GoToUrl(this.URL);
         } */
    }
}

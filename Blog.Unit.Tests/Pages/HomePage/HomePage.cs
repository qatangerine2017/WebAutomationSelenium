using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }


        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
            this.Driver.Manage().Window.Maximize();

        }
        /*  public IWebElement RegirstratonButton
        {
            get
            {
                return this.Driver.FindElement(By.PartialLinkText("Register"));
            } 
        }*/
    }
}

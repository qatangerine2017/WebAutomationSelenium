using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTests.Pages.DeleteArticlePage
{
    public partial class DeleteArticlePage : BasePage
    {
        public DeleteArticlePage(IWebDriver driver) : base(driver)
        {
        }
        public string URL
        {
            get
            {
                return base.Url + "Register/";
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages;

namespace Blog.Unit.Tests.Pages.ReviewingArticles
{
    public partial class ReviewingArticlesPage : BasePage
    {
        public ReviewingArticlesPage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}

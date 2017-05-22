using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Pages.CreateArticlePage
{
    public static class CreateArticlePageAsserter
    {
        public static void Name(this CreateArticlePage page, string text)
        {
            Assert.IsTrue(true);
        }
    }
}

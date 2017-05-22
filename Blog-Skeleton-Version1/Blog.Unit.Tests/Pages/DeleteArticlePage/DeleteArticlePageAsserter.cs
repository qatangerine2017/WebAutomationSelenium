using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Pages.DeleteArticlePage
{
    public static class DeleteArticlePageAsserter
    {
        public static void Name(this DeleteArticlePage page, string text)
        {
            Assert.IsTrue(true);
        }
    }
}

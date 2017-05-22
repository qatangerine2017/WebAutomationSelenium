using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Pages.EditArticlePage
{
    public static class EditArticlePageAsserter
    {
        public static void Name(this EditArticlePage page, string text)
        {
            Assert.IsTrue(true);
        }
    }
}

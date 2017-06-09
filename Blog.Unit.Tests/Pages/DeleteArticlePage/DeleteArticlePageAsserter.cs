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
        public static void AssertTheBlogIsEmpty(this DeleteArticlePage page, string text)
        {
            Assert.IsTrue(page.EmptyPage.Displayed);
        }
        public static void AssertTheArticleIsNotDeleted(this DeleteArticlePage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForDeletingArticle.Displayed);
        }
        public static void AssertTheArticleIsDeleted(this DeleteArticlePage page, string text)
        {
            Assert.IsTrue(page.EmptyArticle.Displayed);
        }
    }
}

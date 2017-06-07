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
        public static void AssertArticleIsCreated(this CreateArticlePage page, string text)
        {
            Assert.IsTrue(page.NewArticle.Displayed);
        }

        public static void AssertTititleArticleIsCreated(this CreateArticlePage page, string text)
        {
            Assert.AreEqual(text, page.TitleField.Text);
        }

        public static void AssertContentArticleIsCreated(this CreateArticlePage page, string text)
        {
            Assert.AreEqual(text, page.ContentField.Text);
        }

        public static void AssertArticleWithoutTitleError(this CreateArticlePage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageForArticleWithoutTitle.Text);
        }
    }
}

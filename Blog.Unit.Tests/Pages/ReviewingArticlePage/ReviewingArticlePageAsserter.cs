using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.CreateArticlePage;

namespace Blog.Unit.Tests.Pages.ReviewingArticle
{
    public static class ReviewingArticlePageAsserter
    {
        public static void AssertArticleIsCreated(this ReviewingArticlePage article, string nameArticle)
        {
            Assert.IsNotEmpty(article.CreatedArticle.Text);
        }

        public static void AssertArticleIsCreatedWithoutTitle(this CreateArticlePage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageForArticleWithoutTitle.Text);
        }

        public static void AssertArticleCreatedWithoutContent(this CreateArticlePage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageForArticleWithoutContent.Text);
        }

        public static void AssertArticleCreatedWithoutTitleAndContentFirstErrorMessage(this CreateArticlePage page, string text)
        {
            Assert.AreEqual(text, page.CombinationOfErrorMessagesWithoutTitle.Text);
        }

        public static void AssertArticleCreatedWithoutTitleAndContentSecondErrorMessage(this CreateArticlePage page, string text)
        {
            Assert.AreEqual(text, page.CombinationOfErrorMessagesWithoutContent.Text);
        }
    }
}

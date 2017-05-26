using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Unit.Tests.Pages.ReviewingArticle
{
    public static class ReviewingArticlePageAsserter
    {
        public static void AssertArticleIsCreated(this ReviewingArticlePage article, string nameArticle)
        {
            Assert.IsNotEmpty(article.CreatedArticle.Text);
        }
    }
}

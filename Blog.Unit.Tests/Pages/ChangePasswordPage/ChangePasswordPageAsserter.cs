using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Pages.ChangePasswordPage
{
    public static class ChangePasswordPageAsserter
    {
        public static void AssertPasswordIsChange(this ChangePasswordPage page, string text)
        {
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }
    }
}

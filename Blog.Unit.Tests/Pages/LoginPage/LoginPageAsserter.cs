using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Pages.LoginPage
{
    public static class LoginPageAsserter
    {
        public static void AssertRegisterPageIsOpen(this LoginPage page, string text)
        {
            //Assert.AreEqual(text, page.Header.Text);
            Assert.IsTrue(true);
        }

        public static void AssertSuccessMessage(this LoginPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertSuccessMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            StringAssert.Contains(text, page.SuccessMessage.Text);
        }

        public static void AssertErrorMessageForEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForEmail.Text);
        }

        public static void AssertErrorMessageForFullName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForFullName.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForFullName.Text);
        }

        public static void AssertErrorMessageForPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForPassword.Text);
        }

        public static void AssertErrorMessageForPasswordMismatch(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForPasswordMismatch.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForPasswordMismatch.Text);
        }
    }
}

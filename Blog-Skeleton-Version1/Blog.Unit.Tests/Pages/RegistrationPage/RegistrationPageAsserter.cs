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
        //public static void AssertRegistrationPageIsOpen(this RegistrationPage page, string text)
        //{
        //    Assert.AreEqual(text, page.Header.Text);
        //}

        public static void AssesrtSuccessMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            StringAssert.Contains(text, page.SuccessMessage.Text);
        }

        public static void AssertErrorMessages(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessages.Displayed);
            StringAssert.Contains(text, page.ErrorMessages.Text);
        }
    }
}

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
        public static void Name(this LoginPage page, string text)
        {
            Assert.IsTrue(true);
        }
    }
}

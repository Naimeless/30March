using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System;

namespace TestUnitTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestLoginMethod()
        {
            var login = "admin";
            var password = "admin";

            var loginStatus= LoginService.Login(login, password);

            Assert.AreEqual(loginStatus, false);
        }
    }
}

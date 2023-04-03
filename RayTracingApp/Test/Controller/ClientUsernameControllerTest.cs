using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace Test.Controller
{
    [TestClass]

    public class ClientUsernameControllerTest
    {
        private ClientUsernameController _controller;

        [TestMethod]
        public void CanCreateClientUsernameController_OkTest()
        {
            _controller = new ClientUsernameController();
        }

        [TestMethod]
        public void CheckIfClientExists_EmptyString_OkTest()
        {
            _controller = new ClientUsernameController();
            bool result = _controller.CheckIfClientExists("");
            Assert.IsFalse(result);
        }

    }
}

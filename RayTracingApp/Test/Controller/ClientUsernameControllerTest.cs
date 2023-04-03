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

    }
}

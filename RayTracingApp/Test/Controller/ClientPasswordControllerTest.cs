using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace Test.Controller
{
    [TestClass]
    public class ClientPasswordControllerTest
    {
        private ClientPasswordController _controller;

        [TestMethod]
        public void canCreateClientPasswordController_OkTest()
        {
            _controller = new ClientPasswordController();
        }
    }
}

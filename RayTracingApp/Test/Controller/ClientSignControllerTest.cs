using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Controller
{
    [TestClass]
    public class ClientSignControllerTest
    {
        private ClientSignController _controller;

        [TestMethod]
        public void CanCreateClientSignController_OkTest()
        {
            _controller = new ClientSignController();
        }
    }
}

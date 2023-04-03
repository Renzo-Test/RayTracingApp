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
        public void CanCreateClientPasswordController_OkTest()
        {
            _controller = new ClientPasswordController();
        }

        [TestMethod]
        public void CheckIfContainsNumber_EmptyString_OkTest()
        {
            _controller = new ClientPasswordController();
            bool result = _controller.CheckIfContainsNumber("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfContainsNumber_1_OkTest()
        {
            _controller = new ClientPasswordController();
            bool result = _controller.CheckIfContainsNumber("1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfContainsNumber_ab_OkTest()
        {
            _controller = new ClientPasswordController();
            bool result = _controller.CheckIfContainsNumber("a1");
            Assert.IsTrue(result);
        }
    }
}

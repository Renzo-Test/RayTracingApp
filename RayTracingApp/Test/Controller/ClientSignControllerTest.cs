using System;
using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

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

        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret1_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Gomez", "GomezSecret1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckSignUp_GomezQuestionMark_GomezSecret1_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Gomez?", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Go_GomezSecret1_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Go", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_gomezsecret1_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Gomez", "gomezsecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Gomez", "GomezSecret");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_Gom1_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Gomez", "Gom1");
            Assert.IsFalse(result);
        }


    }
}

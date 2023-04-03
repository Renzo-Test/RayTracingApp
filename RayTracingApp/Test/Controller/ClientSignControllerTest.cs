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
        public void CheckSignUp_Gomez_GomezSecret_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Gomez", "GomezSecret");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_EmptyString_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Gomez?", "GomezSecret");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Go_GomezSecret_OkTest()
        {
            _controller = new ClientSignController();
            bool result = _controller.SignUp("Go", "GomezSecret");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_AlreadyExisting_Gomez_GomezSecret_OkTest()
        {
            _controller = new ClientSignController();

            Client _client = new Client()
            {
                Username = "Gomez",
            };

            _controller.Repository.AddClient(_client);

            bool result = _controller.SignUp("Gomez", "GomezSecret");
            Assert.IsFalse(result);
        }


    }
}

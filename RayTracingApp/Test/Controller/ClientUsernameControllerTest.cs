using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using IRepository;
using MemoryRepository;
using Model;

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

        [TestMethod]
        public void CheckIfClientExists_Gomez_OkTest()
        {
            _controller = new ClientUsernameController();

            Client _client = new Client()
            {
                Username = "Gomez",
            };

            _controller.Repository.AddClient(_client);
            
            bool result = _controller.CheckIfClientExists("Gomez");
            Assert.IsTrue(result);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;
using MemoryRepository.Exceptions;
using Controller.ClientExceptions;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class ClientRepositoryTest
    {
        private ClientRepository _clientRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _clientRepository = new ClientRepository();
        }

        [TestMethod]
        public void CreateClientRepository_OkTest()
        {
            _clientRepository = new ClientRepository();
        }

        [TestMethod]
        public void AddClientToClientRepository_OkTest()
        {
            _clientRepository.AddClient("Gomez", "GomezSecret");
        }

        [TestMethod]
        public void GetClient_OkTest()
        {
            _clientRepository.AddClient("user", "pass");
            Assert.AreEqual("user", _clientRepository.GetClient("user").Username);
            Assert.AreEqual("pass", _clientRepository.GetClient("user").Password);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundClientException))]
        public void GetClient_NotAddedClient_FailTest()
        {
            Assert.AreEqual("user", _clientRepository.GetClient("user").Username);
        }
    }
}

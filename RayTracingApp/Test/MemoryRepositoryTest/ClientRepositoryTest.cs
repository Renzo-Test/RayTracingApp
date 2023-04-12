using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;


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
        public void GetPassword_OkTest()
        {
            _clientRepository.AddClient("user", "pass");
            Assert.AreEqual("pass", _clientRepository.GetPassword("user"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetPasswordOfEmptyUsername_FailTest()
        {
            _clientRepository.GetPassword("");
        }

        [TestMethod]
        public void GetPassword_RandomPass_OkTest()
        {
            _clientRepository.AddClient("user", "RandomPass");
            Assert.AreEqual("RandomPass", _clientRepository.GetPassword("user"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetPasswordOfNotCreatedUsername_FailTest()
        {
            Assert.AreEqual("pass", _clientRepository.GetPassword("notCreatedUsername"));
        }

        [TestMethod]
        public void GetClient_OkTest()
        {
            _clientRepository.AddClient("user", "pass");
            Assert.AreEqual("user", _clientRepository.GetClient(""));
        }
    }
}

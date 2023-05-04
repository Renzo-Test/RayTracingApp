using MemoryRepository;
using MemoryRepository.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            _clientRepository.AddClient("Gomez", "GomezSecret123");
        }

        [TestMethod]
        public void GetClient_OkTest()
        {
            _clientRepository.AddClient("user", "Password123");
            Assert.AreEqual("user", _clientRepository.GetClient("user").Username);
            Assert.AreEqual("Password123", _clientRepository.GetClient("user").Password);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundClientException))]
        public void GetClient_NotAddedClient_FailTest()
        {
            Assert.AreEqual("user", _clientRepository.GetClient("user").Username);
        }
    }
}

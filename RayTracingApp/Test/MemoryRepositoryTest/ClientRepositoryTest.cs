using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;

namespace Test.MemoryRepository
{
    [TestClass]
    public class ClientRepositoryTest
    {
        private ClientRepository _clientRepository;

        [TestMethod]
        public void createClientRepository_OkTest()
        {
            _clientRepository = new ClientRepository();
        }
    }
}

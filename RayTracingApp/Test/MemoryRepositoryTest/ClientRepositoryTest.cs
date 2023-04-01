using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;
using Model;
using System.Collections.Generic;

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

        [TestMethod]
        public void addClientToClientRepository_OkTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.addClient(new Client());
        }
    }
}

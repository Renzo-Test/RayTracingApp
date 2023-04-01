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

        [TestMethod]
        public void getPassword_OkTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.addClient(new Client() { Username = "user", Password = "pass" });
            Assert.AreEqual("pass", _clientRepository.getPassword("user"));
        }

        [TestMethod]
        [ExpectedException(typeof(ClientRepositoryExcepcion))]
        public void getPasswordOfEmptyUsername_OkTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.getPassword("");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;
using MemoryRepository.Exceptions;
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
        [ExpectedException(typeof(NullReferenceException))]
        public void getPasswordOfEmptyUsername_FailTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.getPassword("");
        }

        [TestMethod]
        public void getPassword_RandomPass_OkTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.addClient(new Client() { Username = "user", Password = "RandomPass" });
            Assert.AreEqual("RandomPass", _clientRepository.getPassword("user"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void getPasswordOfNotCreatedUsername_FailTest()
        {
            _clientRepository = new ClientRepository();
            Assert.AreEqual("pass", _clientRepository.getPassword("notCreatedUsername"));
        }
    }
}

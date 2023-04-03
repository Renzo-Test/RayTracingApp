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
        public void CreateClientRepository_OkTest()
        {
            _clientRepository = new ClientRepository();
        }

        [TestMethod]
        public void AddClientToClientRepository_OkTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.AddClient(new Client());
        }

        [TestMethod]
        public void GetPassword_OkTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.AddClient(new Client() { Username = "user", Password = "pass" });
            Assert.AreEqual("pass", _clientRepository.GetPassword("user"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetPasswordOfEmptyUsername_FailTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.GetPassword("");
        }

        [TestMethod]
        public void GetPassword_RandomPass_OkTest()
        {
            _clientRepository = new ClientRepository();
            _clientRepository.AddClient(new Client() { Username = "user", Password = "RandomPass" });
            Assert.AreEqual("RandomPass", _clientRepository.GetPassword("user"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetPasswordOfNotCreatedUsername_FailTest()
        {
            _clientRepository = new ClientRepository();
            Assert.AreEqual("pass", _clientRepository.GetPassword("notCreatedUsername"));
        }
    }
}

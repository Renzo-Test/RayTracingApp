using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;

namespace Test.MemoryRepository
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void createClientList_OkTest()
        {
            ClientRepository clientRepository = new ClientRepository();
        }
    }
}

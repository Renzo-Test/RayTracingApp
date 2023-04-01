using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;


namespace Test.Model
{
    [TestClass]
    public class ClientTest
    {
        private Client _client;

        [TestMethod]
        public void canCreateClient_OkTest()
        {
           _client = new Client();
        }
    }
}

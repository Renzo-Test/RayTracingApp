using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;


namespace Test.Model
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void canCreateClient_OkTest()
        {
            Client _client = new Client();
        }
    }
}

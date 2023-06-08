using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Domain;

namespace Test.ModelsTest
{
    [TestClass]
    public class LogTest
    {

        [TestMethod]
        public void CanCreateLog_OkTest()
        {
            Log newLog = new Log();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Domain;

namespace Test.ModelsTest
{
    [TestClass]
    public class LogTest
    {
        private Log _log;

        [TestMethod]
        public void CanCreateLog_OkTest()
        {
            _log = new Log();
        }

        [TestMethod]
        public void SetUsername_OkTest()
        {
            _log = new Log()
            {
                Username = "Username123"
            };
        }

        [TestMethod]
        public void SetRenderDate_OkTest()
        {
            Log newLog = new Log();
            newLog.RenderDate = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }
    }
}

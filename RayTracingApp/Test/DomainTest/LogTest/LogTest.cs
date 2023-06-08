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
            Assert.AreEqual("Username123", _log.Username);
        }

        [TestMethod]
        public void SetRenderDate_OkTest()
        {
            _log = new Log()
            {
                RenderDate = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy")
            };
            string expected = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
            Assert.AreEqual(expected, _log.RenderDate);
        }

        [TestMethod]
        public void SetTimeSpan_OkTest()
        {
            _log = new Log()
            {
                TimeSpan = TimeSpan.FromSeconds(1)
            };

            Assert.AreEqual(TimeSpan.FromSeconds(1), _log.TimeSpan);
        }
        
        [TestMethod]
        public void SetSceneName_OkTest()
        {
            Log newLog = new Log();
            newLog.SceneName = "Test";
            Assert.AreEqual("Test", log.SceneName);
        }

    }
}


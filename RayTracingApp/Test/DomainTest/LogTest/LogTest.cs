﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Log newLog = new Log();
            newLog.Username = "Username123";
        }
    }
}

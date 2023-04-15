using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.ModelTest.ModelTest
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void CreateModel_OkTest()
        {
            Model = new Model();
        }
    }
}

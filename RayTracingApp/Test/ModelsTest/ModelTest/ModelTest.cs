using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;

namespace Test.ModelsTest
{
    [TestClass]
    public class ModelsTest
    {
        [TestMethod]
        public void CreateModels_OkTest()
        {
            Model newModel= new Model();
        }

        [TestMethod]
        public void SetOwner_OkTest()
        {
            Model newModel = new Model()
            {
                Owner = "ownerName"
            };
            Assert.AreEqual("ownerName", newModel.Owner);
        }
    }
}

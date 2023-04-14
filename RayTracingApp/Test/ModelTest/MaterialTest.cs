using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model;

namespace Test.ModelTest
{
    [TestClass]

    public class Class1
    {
        private Material _material;

        [TestMethod]
        public void CanCreateMaterial_OkTest()
        {
            _material = new Material();
        }

        [TestMethod]
        public void SetOwner_Gomez_OkTest()
        {
            _material = new Material()
            {
                Owner = "Gomez",
            };
            Assert.AreEqual("Gomez", _material.Owner);
        }
    }
}

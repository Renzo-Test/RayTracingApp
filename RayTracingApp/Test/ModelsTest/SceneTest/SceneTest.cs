using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;

namespace Test.ModelsTest
{
    [TestClass]

    public class SceneTest
    {
        [TestMethod]
        public void CreateScene_OkTest()
        {
            Scene newScene = new Scene();
        }

        [TestMethod]
        public void SetOwner_OkTest()
        {
            Scene newScene = new Scene()
            {
                Owner = "ownerName"
            };
            Assert.AreEqual("ownerName", newScene.Owner);
        }

    }
}

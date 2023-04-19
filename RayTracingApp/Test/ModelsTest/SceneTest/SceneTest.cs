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

        [TestMethod]
        public void SetName_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "modelName"
            };
            Assert.AreEqual("modelName", newScene.Name);
        }

        [TestMethod]
        public void CanGetRegisterTime_OkTest()
        {
            Scene newScene = new Scene();
            String today = DateTime.Now.ToString("hh:mm:ss - yyyy/MM/dd");
            Assert.AreEqual(today, newScene.RegisterTime);
        }

        [TestMethod]
        public void CanGetLastModificationDate_OkTest()
        {
            Scene newScene = new Scene();
            String expected = "unmodified";
            Assert.AreEqual(expected, newScene.LastModificationDate);
        }

        [TestMethod]
        public void CanGetLastRenderDate_OkTest()
        {
            Scene newScene = new Scene();
            String expected = "unrendered";
            Assert.AreEqual(expected, newScene.LastRenderDate);
        }



    }
}

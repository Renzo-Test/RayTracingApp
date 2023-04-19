using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;

namespace Test.ModelsTest
{
    [TestClass]

    public class SceneTest
    {
        private Scene _scene;

        [TestMethod]
        public void CreateScene_OkTest()
        {
            Scene newScene = new Scene();
        }

        [TestMethod]
        public void SetOwner_OkTest()
        {
            _scene = new Scene()
            {
                Owner = "ownerName"
            };
            Assert.AreEqual("ownerName", _scene.Owner);
        }

        [TestMethod]
        public void SetName_OkTest()
        {
            _scene = new Scene()
            {
                Name = "modelName"
            };
            Assert.AreEqual("modelName", _scene.Name);
        }

        [TestMethod]
        public void CanGetRegisterTime_OkTest()
        {
            _scene = new Scene();
            String today = DateTime.Now.ToString("hh:mm:ss - yyyy/MM/dd");
            Assert.AreEqual(today, _scene.RegisterTime);
        }

        [TestMethod]
        public void CanGetLastModificationDate_OkTest()
        {
            _scene = new Scene();
            String expected = "unmodified";
            Assert.AreEqual(expected, _scene.LastModificationDate);
        }

        [TestMethod]
        public void CanGetLastRenderDate_OkTest()
        {
            _scene = new Scene();
            String expected = "unrendered";
            Assert.AreEqual(expected, _scene.LastRenderDate);
        }

        [TestMethod]
        public void SetFov_OkTest()
        {
            _scene = new Scene()
            {
                Fov  = 100,
            };
            Assert.AreEqual(100, _scene.Fov);
        }




    }
}

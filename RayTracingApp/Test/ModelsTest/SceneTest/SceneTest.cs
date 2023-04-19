using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Reflection;

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

        [TestMethod]
        public void SetCameraPosition_OkTest()
        {
            Coordinate newCoordinate = new Coordinate()
            {
                X = 10,
                Y = 20,
                Z = 30,
            };
            
            _scene = new Scene()
            {
                CameraPosition = newCoordinate,
            };
            Assert.AreEqual(newCoordinate, _scene.CameraPosition);
        }

        [TestMethod]
        public void InitializeCameraPosition_DefaultValue_OkTest()
        {
            Coordinate newCoordinate = new Coordinate()
            {
                X = 0,
                Y = 2,
                Z = 0,
            };

            _scene = new Scene();

            foreach (PropertyInfo property in newCoordinate.GetType().GetProperties())
            {
                Assert.AreEqual(property.GetValue(newCoordinate), property.GetValue(_scene.CameraPosition));
            }
        }

        [TestMethod]
        public void SetObjectivePosition_OkTest()
        {
            Coordinate newCoordinate = new Coordinate()
            {
                X = 10,
                Y = 20,
                Z = 30,
            };

            _scene = new Scene()
            {
                ObjectivePosition = newCoordinate,
            };
            Assert.AreEqual(newCoordinate, _scene.ObjectivePosition);
        }

        [TestMethod]
        public void InitializeObjectivePosition_DefaultValue_OkTest()
        {
            Coordinate newCoordinate = new Coordinate()
            {
                X = 0,
                Y = 2,
                Z = 5,
            };

            _scene = new Scene();

            foreach (PropertyInfo property in newCoordinate.GetType().GetProperties())
            {
                Assert.AreEqual(property.GetValue(newCoordinate), property.GetValue(_scene.ObjectivePosition));
            }
        }




    }
}

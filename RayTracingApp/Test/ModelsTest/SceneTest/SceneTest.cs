using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Test.ModelsTest
{
    [TestClass]
	[ExcludeFromCodeCoverage]
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
            String today = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
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
                Fov = 100,
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

        [TestMethod]
        public void SetPosisionatedModels_OkTest()
        {

            Coordinate firstCoordinate = new Coordinate()
            {
                X = 0,
                Y = 2,
                Z = 5,
            };

            Coordinate secondCoordinate = new Coordinate()
            {
                X = 12,
                Y = 0,
                Z = 3,
            };

            Model firstModel = new Model()
            {
                Name = "firstModelName",
                Owner = "firstOwnerName"
            };

            Model secondModel = new Model()
            {
                Name = "secondModelName",
                Owner = "secondOwnerName"
            };

            List<PosisionatedModel> posisionatedModels = new List<PosisionatedModel>()
            {
                new PosisionatedModel()
                {
                    Position = firstCoordinate,
                    Model = firstModel
                },

                new PosisionatedModel() {
                    Position = secondCoordinate,
                    Model = secondModel
                }
            };

            _scene = new Scene()
            {
                PosisionatedModels = posisionatedModels,
            };


            for (int i = 0; i < posisionatedModels.Count; i++)
            {
                foreach (PropertyInfo property in posisionatedModels[i].GetType().GetProperties())
                {
                    Assert.AreEqual(property.GetValue(posisionatedModels[i]), property.GetValue(_scene.PosisionatedModels[i]));
                }
            }

        }






    }
}

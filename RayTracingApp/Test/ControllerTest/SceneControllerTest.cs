using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using Models;
using Controller.SceneExceptions;
using System;
using System.Collections.Generic;

namespace Test.ControllerTest
{
    [TestClass]
    public class SceneControllerTest
    {
        private SceneController _sceneController;

        [TestInitialize]
        public void TestInitialize()
        {
            _sceneController = new SceneController();
        }

        [TestMethod]
        public void CreateSceneController_OkTest()
        {
            SceneController sceneController = new SceneController(); 
        }

        [TestMethod]
        public void AddScene_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "Test",
            };

            _sceneController.AddScene(newScene, "ownerName");

            CollectionAssert.Contains(_sceneController.Repository.GetScenesByClient("ownerName"), newScene);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSceneInputException))]
        public void AddScene_EmptyName_FailTest()
        {
            Scene newScene = new Scene()
            {
                Name = ""
            };

            _sceneController.AddScene(newScene, "owneraName");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSceneInputException))]
        public void AddScene_StartWithSpace_FailTest()
        {
            Scene newScene = new Scene()
            {
                Name = " sceneName"
            };

            _sceneController.AddScene(newScene, "owneraName");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSceneInputException))]
        public void AddScene_EndWithSpace_FailTest()
        {
            Scene newScene = new Scene()
            {
                Name = "sceneName "
            };

            _sceneController.AddScene(newScene, "owneraName");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSceneInputException))]
        public void AddScene_AlreadyExistingSceneName_FailTest()
        {
            Scene newScene = new Scene()
            {
                Name = "sceneName"
            };

            _sceneController.AddScene(newScene, "owneraName");
            _sceneController.AddScene(newScene, "owneraName");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSceneInputException))]
        public void AddScene_LessThanMinFov_FailTest()
        {
            Scene newScene = new Scene()
            {
                Name = "sceneName",
                Fov = 0
            };

            _sceneController.AddScene(newScene, "owneraName");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidSceneInputException))]
        public void AddScene_BiggerThanMaxFov_FailTest()
        {
            Scene newScene = new Scene()
            {
                Name = "sceneName",
                Fov = 161
            };

            _sceneController.AddScene(newScene, "owneraName");
        }

        [TestMethod]
        public void UpdateLastModificationDate_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "sceneName"
            };

            _sceneController.UpdateLastModificationDate(newScene);
            Assert.AreEqual(DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy"), newScene.LastModificationDate);
        }

        [TestMethod]
        public void UpdateLastRenderDate_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "sceneName"
            };

            _sceneController.UpdateLastRenderDate(newScene);
            Assert.AreEqual(DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy"), newScene.LastRenderDate);
        }

        [TestMethod]
        public void ListScenes_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "scene"
            };
            Scene anotherScene = new Scene()
            {
                Name = "anotherScene"
            };

            _sceneController.AddScene(newScene, "ownerName");
            _sceneController.AddScene(anotherScene, "ownerName");

            List<Scene> ownerScenes = _sceneController.ListScenes("ownerName");
            CollectionAssert.Contains(ownerScenes, newScene);
            CollectionAssert.Contains(ownerScenes, anotherScene);
        }

        [TestMethod]
        public void RemoveScene_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "scene"
            };

            _sceneController.AddScene(newScene, "ownerName");

            _sceneController.RemoveScene("scene");
            CollectionAssert.DoesNotContain(_sceneController.ListScenes("ownerName"), newScene);
        }
    }
}

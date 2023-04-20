using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using Models;
using Controller.SceneExceptions;
using System;

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
        public void UpdateLastModificationDate_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "sceneName"
            };

            _sceneController.UpdateLastModificationDate(newScene);
            Assert.AreEqual(DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy"), newScene.LastModificationDate);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using Models;
using Controller.SceneExceptions;
using System;
using System.Collections.Generic;
using MemoryRepository.Exceptions;

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

        public void RemoveScene_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "scene"
            };

            _sceneController.AddScene(newScene, "ownerName");

            _sceneController.RemoveScene("scene", "ownerName");
            CollectionAssert.DoesNotContain(_sceneController.ListScenes("ownerName"), newScene);
        }

        [TestMethod]
        public void RemoveScene_TwoClients_OkTest()
        {
            Scene newScene = new Scene()
            {
                Name = "scene"
            };
            Scene anotherScene = new Scene()
            {
                Name = "anotherScene"
            };

            _sceneController.AddScene(newScene, "firstOwner");
            _sceneController.AddScene(anotherScene, "secondOwner");

            _sceneController.RemoveScene("scene", "firstOwner");
            CollectionAssert.Contains(_sceneController.ListScenes("secondOwner"), anotherScene);
        }

        [TestMethod]
        public void GetAvailableModels_OkTest()
        {
            Model newModel = new Model()
            {
                Name = "modelName"
            };
            PosisionatedModel posisionatedModel = new PosisionatedModel();
            posisionatedModel.Model = newModel;

            List<PosisionatedModel> sceneModels = new List<PosisionatedModel>();
            sceneModels.Add(posisionatedModel);

            Scene newScene = new Scene()
            {
                Name = "scene",
                PosisionatedModels = sceneModels
            };

            Model availableModel = new Model()
            {
                Name = "unusedModel"
            };

            ModelController modelController = new ModelController();
            modelController.AddModel(newModel, "ownerName");
            modelController.AddModel(availableModel, "ownerName");
            _sceneController.AddScene(newScene, "ownerName");
            List<Model> ownerModels = modelController.ListModels("ownerName");

            CollectionAssert.Contains(_sceneController.GetAvailableModels(newScene, ownerModels), availableModel);
        }

        [TestMethod]
        public void GetAvailableModels_ContainsAllUnusedModels_OkTest()
        {
            Model availableModel = new Model()
            {
                Name = "modelName"
            };
            PosisionatedModel posisionatedModel = new PosisionatedModel();
            posisionatedModel.Model = availableModel;

            Scene newScene = new Scene()
            {
                Name = "scene",
                PosisionatedModels = new List<PosisionatedModel>()
            };

            Model otherAvailableModel = new Model()
            {
                Name = "unusedModel"
            };

            ModelController modelController = new ModelController();
            modelController.AddModel(otherAvailableModel, "ownerName");
            modelController.AddModel(availableModel, "ownerName");
            _sceneController.AddScene(newScene, "ownerName");
            List<Model> ownerModels = modelController.ListModels("ownerName");

            CollectionAssert.Contains(_sceneController.GetAvailableModels(newScene, ownerModels), availableModel);
            CollectionAssert.Contains(_sceneController.GetAvailableModels(newScene, ownerModels), otherAvailableModel);
        }

        [TestMethod]
        public void GetAvailableModels_OnlyContainsUnusedModels_OkTest()
        {
            Model newModel = new Model()
            {
                Name = "modelName"
            };
            PosisionatedModel posisionatedModel = new PosisionatedModel();
            posisionatedModel.Model = newModel;

            List<PosisionatedModel> sceneModels = new List<PosisionatedModel>();
            sceneModels.Add(posisionatedModel);

            Scene newScene = new Scene()
            {
                Name = "scene",
                PosisionatedModels = sceneModels
            };

            Model availableModel = new Model()
            {
                Name = "unusedModel"
            };

            ModelController modelController = new ModelController();
            modelController.AddModel(newModel, "ownerName");
            modelController.AddModel(availableModel, "ownerName");
            _sceneController.AddScene(newScene, "ownerName");
            List<Model> ownerModels = modelController.ListModels("ownerName");

            CollectionAssert.DoesNotContain(_sceneController.GetAvailableModels(newScene, ownerModels), newModel);
        }

        [TestMethod]
        public void CreateBlankScene_SceneName_OkTest()
        {
            Scene blankScene = _sceneController.CreateBlankScene("SceneName");

            Assert.AreEqual(blankScene.Name, "SceneName");
        }

        [TestMethod]
        public void CreateBlankScene_AnotherSceneName_OkTest()
        {
            Scene blankScene = _sceneController.CreateBlankScene("AnotherSceneName");

            Assert.AreEqual(blankScene.Name, "AnotherSceneName");
        }
    }
}

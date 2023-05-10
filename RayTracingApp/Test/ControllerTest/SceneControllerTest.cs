using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Test.ControllerTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class SceneControllerTest
	{
		private SceneController _sceneController;
		private string _owner;
		private int _fov;
		private Vector _lookFrom;
		private Vector _looktTo;

		[TestInitialize]
		public void TestInitialize()
		{
			_sceneController = new SceneController();
			_owner = "ownerName";
			_fov = 70;
			_lookFrom = new Vector() { X = 1, Y = 0, Z = 1 };
			_looktTo = new Vector() { X = 0, Y = 2, Z = 1 };
		}

		[TestMethod]
		public void CreateSceneController_OkTest()
		{
			SceneController sceneController = new SceneController();
		}

		[TestMethod]
		public void AddScene_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = ""
			};
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidSceneInputException))]
		public void AddScene_StartWithSpace_FailTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = " sceneName"
			};
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidSceneInputException))]
		public void AddScene_EndWithSpace_FailTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName "
			};
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidSceneInputException))]
		public void AddScene_AlreadyExistingSceneName_FailTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName",
				Fov = 0
			};
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidSceneInputException))]
		public void AddScene_BiggerThanMaxFov_FailTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName",
				Fov = 161
			};
		}

		[TestMethod]
		public void UpdateLastModificationDate_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName"
			};

			_sceneController.UpdateLastModificationDate(newScene);
			Assert.AreEqual(DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy"), newScene.LastModificationDate);
		}

		[TestMethod]
		public void UpdateLastRenderDate_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName"
			};

			_sceneController.UpdateLastRenderDate(newScene);
			Assert.AreEqual(DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy"), newScene.LastRenderDate);
		}

		[TestMethod]
		public void ListScenes_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "scene"
			};
			Scene anotherScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "scene"
			};
			Scene anotherScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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

			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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

			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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

			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
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
		public void CreateBlankScene_OkTest()
		{
			Client client = new Client()
			{
				Username = "OwnerName",
				DefaultFov = 70,
				DefaultLookFrom = new Vector() { X = 0, Y = 1, Z = 0 },
				DefaultLookAt = new Vector() { X = 1, Y = 0, Z = 1 },
			};
			Scene resetCounter = _sceneController.CreateBlankScene(client);
			resetCounter.ResetCreatedCounter();


			Scene blankScene = _sceneController.CreateBlankScene(client);
			Assert.AreEqual("Blank Scene 1", blankScene.Name);
		}

		[TestMethod]
		public void CreateBlankScene_TwoScenes_OkTest()
		{
			Client client1 = new Client()
			{
				Username = "OwnerName",
				DefaultFov = 70,
				DefaultLookFrom = new Vector() { X = 0, Y = 1, Z = 0 },
				DefaultLookAt = new Vector() { X = 1, Y = 0, Z = 1 },
			};
			Client client2 = new Client()
			{
				Username = "OwnerName",
				DefaultFov = 70,
				DefaultLookFrom = new Vector() { X = 0, Y = 1, Z = 0 },
				DefaultLookAt = new Vector() { X = 1, Y = 0, Z = 1 },
			};

			Scene resetCounter = _sceneController.CreateBlankScene(client1);
			resetCounter.ResetCreatedCounter();

			Scene blankScene1 = _sceneController.CreateBlankScene(client1);
			Scene blankScene2 = _sceneController.CreateBlankScene(client2);

			Assert.AreEqual("Blank Scene 2", blankScene2.Name);
		}
	}
}

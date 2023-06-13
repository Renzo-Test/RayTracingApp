using Controller;
using Domain;
using Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Test.ControllerTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class SceneControllerTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";
		private SceneController _sceneController;
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;
		private int _fov;
		private Vector _lookFrom;
		private Vector _looktTo;

		[TestInitialize]
		public void TestInitialize()
		{
			_sceneController = new SceneController(TestDatabase);
			_clientController = new ClientController(TestDatabase);

			_clientController.SignUp("ownerName", "Password123");
			_owner = _clientController.SignIn("ownerName", "Password123");

			_clientController.SignUp("otherName", "Password123");
			_otherOwner = _clientController.SignIn("otherName", "Password123");

			_fov = 70;
			_lookFrom = new Vector() { X = 1, Y = 0, Z = 1 };
			_looktTo = new Vector() { X = 0, Y = 2, Z = 1 };
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.TestAppContext(TestDatabase))
			{
				context.ClearDBTable("Scenes");
				context.ClearDBTable("Models");
				context.ClearDBTable("Clients");
			}
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

			_sceneController.AddScene(newScene, _owner);

			Assert.AreEqual(_sceneController.Repository.GetScenesByClient(_owner)[0].Id, newScene.Id);
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

			_sceneController.AddScene(newScene, _owner);
			_sceneController.AddScene(newScene, _owner);
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
		public void UpdateSceneName_OkTest()
		{
			Scene scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName",
			};

			_sceneController.AddScene(scene, _owner);
			_sceneController.UpdateSceneName(scene, _owner, "newName");

			Assert.AreEqual("newName", _sceneController.ListScenes(_owner)[0].Name);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidSceneInputException))]
		public void UpdateSceneName_startSpace_FailTest()
		{
			Scene scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName",
			};

			_sceneController.UpdateSceneName(scene, _owner, " newName");
		}

		[TestMethod]
		public void UpdateSceneName_KeepPreviousNameIfInvalid_OkTest()
		{
			Scene scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName",
			};

			try
			{
				_sceneController.UpdateSceneName(scene, _owner, " invalidName ");
			}
			catch (InvalidSceneInputException)
			{
				Assert.AreEqual("sceneName", scene.Name);
			}
		}


		[TestMethod]
		public void UpdateLastModificationDate_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName"
			};

			_sceneController.UpdateLastModificationDate(newScene);
			Assert.AreEqual(DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy"), newScene.LastModificationDate);
		}

		[TestMethod]
		public void UpdateLastRenderDate_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "sceneName"
			};

			_sceneController.UpdateLastRenderDate(newScene);
			Assert.AreEqual(DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy"), newScene.LastRenderDate);
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

			_sceneController.AddScene(newScene, _owner);
			_sceneController.AddScene(anotherScene, _owner);

			List<Scene> ownerScenes = _sceneController.ListScenes(_owner);
			Assert.AreEqual(ownerScenes[0].Id, newScene.Id);
			Assert.AreEqual(ownerScenes[1].Id, anotherScene.Id);
		}

		[TestMethod]
		public void RemoveScene_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "scene"
			};

			_sceneController.AddScene(newScene, _owner);

			_sceneController.RemoveScene("scene", _owner);
			CollectionAssert.DoesNotContain(_sceneController.ListScenes(_owner), newScene);
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

			_sceneController.AddScene(newScene, _owner);
			_sceneController.AddScene(anotherScene, _otherOwner);

			_sceneController.RemoveScene("scene", _owner);
			Assert.AreEqual(_sceneController.ListScenes(_otherOwner)[0].Id, anotherScene.Id);
		}

		[TestMethod]
		public void CreateBlankScene_OkTest()
		{
			Client client = new Client()
			{
				Username = "ownerName",
				DefaultFov = 70,
				DefaultLookFrom = new Vector() { X = 0, Y = 1, Z = 0 },
				DefaultLookAt = new Vector() { X = 1, Y = 0, Z = 1 },
			};

			Scene blankScene = _sceneController.CreateBlankScene(client);
			Assert.AreEqual(DateTime.Now.ToString("HH.mm.ss - dd-MM-yyyy"), blankScene.Name);
		}

		[TestMethod]
		public void UpdatePreview_OkTest()
		{
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo);
			Bitmap img = new Bitmap(600, 300);
			_sceneController.AddScene(_scene, _owner);

			_sceneController.UpdatePreview(_scene, img);

			Scene updatedScene = _sceneController.ListScenes(_owner)[0];

			Assert.AreEqual(img.ToString(), updatedScene.GetPreview().ToString());
		}

	}
}

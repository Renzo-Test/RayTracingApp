using Controller;
using DBRepository;
using DBRepository.Exceptions;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;

namespace Test.MemoryRepositoryTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class SceneRepositoryTest
	{
		private const string TestDatabase = "RayTracingAppTestDB";

		private SceneRepository _sceneRepository;
		private ClientController _clientController;
		private Client _owner;
		private Client _otherOwner;
		private int _fov;
		private Vector _lookFrom;
		private Vector _looktTo;

		[TestInitialize]
		public void TestInitialize()
		{
			_sceneRepository = new SceneRepository()
			{
				DBName = TestDatabase
			};
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
		public void TestCleanup()
		{
			using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Models");
				context.ClearDBTable("Materials");
				context.ClearDBTable("Figures");
				context.ClearDBTable("Scenes");
				context.ClearDBTable("Clients");
			}
		}

		[TestMethod]
		public void CreateSceneRepository_OkTest()
		{
			_sceneRepository = new SceneRepository();
		}

		[TestMethod]
		public void GetScenesByClient_OwnerName_OkTest()
		{
			Scene _scene = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = _owner,
			};

			_sceneRepository.AddScene(_scene, _owner);

			List<Scene> iterable = _sceneRepository.GetScenesByClient(_owner);
			Assert.AreEqual(iterable[0].Id, _scene.Id);
		}

		[TestMethod]
		public void AddScene_OkTest()
		{
			Scene _scene = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = _owner,
			};

			_sceneRepository.AddScene(_scene, _owner);

		}

		[TestMethod]
		public void AddSTwoScenes_OkTest()
		{
			Scene _scene = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test",
			};

			Scene _scene2 = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test2",
			};

			_sceneRepository.AddScene(_scene, _owner);
			_sceneRepository.AddScene(_scene2, _owner);

			List<Scene> iterable = _sceneRepository.GetScenesByClient(_owner);
			Assert.AreEqual(iterable[0].Id, _scene.Id);
			Assert.AreEqual(iterable[1].Id, _scene2.Id);
		}

		[TestMethod]
		public void AddDifferentClientScenes_OkTest()
		{
			Scene _scene = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = _owner,
			};

			Scene _scene2 = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test2",
				Owner = _otherOwner,
			};

			_sceneRepository.AddScene(_scene, _owner);
			_sceneRepository.AddScene(_scene2, _otherOwner);

			List<Scene> iterableOwner1 = _sceneRepository.GetScenesByClient(_owner);
			List<Scene> iterableOwner2 = _sceneRepository.GetScenesByClient(_otherOwner);
			Assert.AreEqual(iterableOwner1[0].Id, _scene.Id);
			Assert.AreEqual(iterableOwner2[0].Id, _scene2.Id);
		}

		[TestMethod]
		public void GetScenesByClient_NoClient_OkTest()
		{
			List<Scene> scenes = _sceneRepository.GetScenesByClient(_owner);

			Assert.IsFalse(scenes.Any());
		}

		[TestMethod]
		public void DeleteScene_ExistingScene_OkTest()
		{
			Scene _scene = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = _owner,
			};

			_sceneRepository.AddScene(_scene, _owner);

			_sceneRepository.RemoveScene(_scene);

			List<Scene> iterableOwner1 = _sceneRepository.GetScenesByClient(_owner);
			CollectionAssert.DoesNotContain(iterableOwner1, _scene);
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundSceneException))]
		public void DeleteScene_NonExistingScene_OkTest()
		{
			Scene _scene = new Scene(_fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = _owner,
			};

			_sceneRepository.RemoveScene(_scene);

			List<Scene> iterableOwner1 = _sceneRepository.GetScenesByClient(_owner);
			CollectionAssert.DoesNotContain(iterableOwner1, _scene);
		}

		[TestMethod]
		public void UpdatePreview_OkTest()
		{
			Scene _scene = new Scene(_fov, _lookFrom, _looktTo);
			Bitmap img = new Bitmap(600, 300);
			_sceneRepository.AddScene(_scene, _owner);

			_sceneRepository.UpdateScenePreview(_scene, img);

			Scene updatedScene = _sceneRepository.GetScenesByClient(_owner)[0];

			Assert.AreEqual(img.ToString(), updatedScene.GetPreview().ToString());
		}

		[TestMethod]
		public void UpdateModels_OkTest()
		{
			FigureRepository figureRepository = new FigureRepository()
			{
				DBName = TestDatabase
			};
			MaterialRepository materialRepository = new MaterialRepository()
			{
				DBName = TestDatabase
			};
			ModelRepository modelRepository = new ModelRepository()
			{
				DBName = TestDatabase
			};

			Scene _scene = new Scene(_fov, _lookFrom, _looktTo);
			_sceneRepository.AddScene(_scene, _owner);

			Figure figure = new Sphere();
			figureRepository.AddFigure(figure, _owner);

			Material material = new Lambertian()
			{
				Color = new Domain.Color(),
			};
			materialRepository.AddMaterial(material, _owner);

			Model model = new Model()
			{
				Figure = figure,
				Material = material,
			};	
			modelRepository.AddModel(model, _owner);

			_sceneRepository.UpdateSceneModels(_scene, new PosisionatedModel()
			{
				Model = model,
				Position = new Vector() { X = 0, Y = 0, Z = 0 },
			});

			Assert.AreEqual(1, _sceneRepository.GetPosisionatedModels(_scene).Count);
		}
	}
}

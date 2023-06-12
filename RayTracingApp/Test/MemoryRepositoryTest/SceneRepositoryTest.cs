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
		private SceneRepository _sceneRepository;
		private string _owner;
		private int _fov;
		private Vector _lookFrom;
		private Vector _looktTo;

		[TestInitialize]
		public void TestInitialize()
		{
			_sceneRepository = new SceneRepository()
			{
				DBName = "RayTracingAppTestDB"
			};
			_owner = "ownerName";
			_fov = 70;
			_lookFrom = new Vector() { X = 1, Y = 0, Z = 1 };
			_looktTo = new Vector() { X = 0, Y = 2, Z = 1 };
		}
		[TestCleanup]
		public void TestCleanup()
		{
			using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Scenes");
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
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = "OwnerName",
			};

			_sceneRepository.AddScene(_scene);

			List<Scene> iterable = _sceneRepository.GetScenesByClient("OwnerName");
			Assert.AreEqual(iterable[0].Id, _scene.Id);
		}

		[TestMethod]
		public void AddScene_OkTest()
		{
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = "OwnerName",
			};

			_sceneRepository.AddScene(_scene);

		}

		[TestMethod]
		public void AddSTwoScenes_OkTest()
		{
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = "OwnerName",
			};

			Scene _scene2 = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test2",
				Owner = "OwnerName",
			};

			_sceneRepository.AddScene(_scene);
			_sceneRepository.AddScene(_scene2);

			List<Scene> iterable = _sceneRepository.GetScenesByClient("OwnerName");
			Assert.AreEqual(iterable[0].Id, _scene.Id);
			Assert.AreEqual(iterable[1].Id, _scene2.Id);
		}

		[TestMethod]
		public void AddDifferentClientScenes_OkTest()
		{
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = "OwnerName",
			};

			Scene _scene2 = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test2",
				Owner = "OwnerName2",
			};

			_sceneRepository.AddScene(_scene);
			_sceneRepository.AddScene(_scene2);

			List<Scene> iterableOwner1 = _sceneRepository.GetScenesByClient("OwnerName");
			List<Scene> iterableOwner2 = _sceneRepository.GetScenesByClient("OwnerName2");
			Assert.AreEqual(iterableOwner1[0].Id, _scene.Id);
			Assert.AreEqual(iterableOwner2[0].Id, _scene2.Id);
		}

		[TestMethod]
		public void GetScenesByClient_NoClient_OkTest()
		{
			List<Scene> scenes = _sceneRepository.GetScenesByClient("OwnerName");

			Assert.IsFalse(scenes.Any());
		}

		[TestMethod]
		public void DeleteScene_ExistingScene_OkTest()
		{
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = "OwnerName",
			};

			_sceneRepository.AddScene(_scene);

			_sceneRepository.RemoveScene(_scene);

			List<Scene> iterableOwner1 = _sceneRepository.GetScenesByClient("OwnerName");
			CollectionAssert.DoesNotContain(iterableOwner1, _scene);
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundSceneException))]
		public void DeleteScene_NonExistingScene_OkTest()
		{
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "Test",
				Owner = "OwnerName",
			};

			_sceneRepository.RemoveScene(_scene);

			List<Scene> iterableOwner1 = _sceneRepository.GetScenesByClient("OwnerName");
			CollectionAssert.DoesNotContain(iterableOwner1, _scene);
		}

		[TestMethod]
		public void UpdatePreview_OkTest()
		{
			Scene _scene = new Scene(_owner, _fov, _lookFrom, _looktTo);
			Bitmap img = new Bitmap(600, 300);
			_sceneRepository.AddScene(_scene);

			_sceneRepository.UpdateScenePreview(_scene, img);

			Scene updatedScene = _sceneRepository.GetScenesByClient(_owner)[0];

			Assert.AreEqual(img.ToString(), updatedScene.GetPreview().ToString());
		}
	}
}

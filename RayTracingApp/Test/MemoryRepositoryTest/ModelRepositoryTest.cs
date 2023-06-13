using DBRepository;
using DBRepository.Exceptions;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using Color = Domain.Color;

namespace Test.MemoryRepositoryTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class ModelRepositoryTest
	{
		private ModelRepository _modelRepository;
		private Client _owner;

		[TestInitialize]
		public void TestInitialize()
		{
			_modelRepository = new ModelRepository()
			{
				DBName = "RayTracingAppTestDB"
			};

			_owner = new Client() { Username = "OwnerName" };
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.TestAppContext("RayTracingAppTestDB"))
			{
				context.ClearDBTable("Models");
			}
		}

		[TestMethod]
		public void CreateModelRepositoryOk_Test()
		{
			_modelRepository = new ModelRepository();
		}
		[TestMethod]
		public void GetModelsByClient_Username_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = _owner,
				Name = "Name",
			};
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = _owner,
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = _owner,
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.AddModel(NewModel, _owner);

			Assert.AreEqual(NewModel.Id, _modelRepository.GetModelsByClient(NewModel.Owner)[0].Id);
		}

		[TestMethod]
		public void AddModel_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = _owner,
				Name = "Name",
			};
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = _owner,
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = _owner,
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.AddModel(NewModel, _owner);
		}

		[TestMethod]
		public void RemoveModel_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = _owner,
				Name = "Name",
			};
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = _owner,
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = _owner,
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.AddModel(NewModel, _owner);
			_modelRepository.RemoveModel(NewModel);
			List<Model> iterable = _modelRepository.GetModelsByClient(_owner);
			CollectionAssert.DoesNotContain(iterable, NewModel);
		}

		[TestMethod]
		[ExpectedException(typeof(NotFoundModelException))]
		public void RemoveModel_NotExistingModel_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = _owner,
				Name = "Name",
			};
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = _owner,
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = _owner,
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.RemoveModel(NewModel);
			_modelRepository.GetModelsByClient(_owner);
		}

		[TestMethod]
		public void UpdatePreview_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = _owner,
				Name = "Name",
			};
			Color NewColor = new Color()
			{
				Red = 222,
				Green = 222,
				Blue = 222,
			};

			Material NewMaterial = new Lambertian()
			{
				Name = "Test",
				Owner = _owner,
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = _owner,
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};

			Bitmap img = new Bitmap(600, 300);
			_modelRepository.AddModel(NewModel, _owner);

			_modelRepository.UpdatePreview(NewModel, img);

			Model updatedModel = _modelRepository.GetModelsByClient(_owner)[0];

			Assert.AreEqual(img.ToString(), updatedModel.GetPreview().ToString());
		}

	}
}

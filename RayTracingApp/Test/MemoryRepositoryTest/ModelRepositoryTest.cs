using DBRepository;
using DBRepository.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
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

		[TestInitialize]
		public void TestInitialize()
		{
			_modelRepository = new ModelRepository()
			{
				DBName = "RayTracingAppTestDB"
			};
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			using (var context = new DBRepository.AppContext("RayTracingAppTestDB"))
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
				Owner = "OwnerName",
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
				Owner = "OwnerName",
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = "Username",
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.AddModel(NewModel);

			Assert.AreEqual(NewModel.Id, _modelRepository.GetModelsByClient(NewModel.Owner)[0].Id);
		}

		[TestMethod]
		public void AddModel_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = "OwnerName",
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
				Owner = "OwnerName",
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = "Username",
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.AddModel(NewModel);
		}

		[TestMethod]
		public void RemoveModel_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = "OwnerName",
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
				Owner = "OwnerName",
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = "OwnerName",
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.AddModel(NewModel);
			_modelRepository.RemoveModel(NewModel);
			List<Model> iterable = _modelRepository.GetModelsByClient("OwnerName");
			CollectionAssert.DoesNotContain(iterable, NewModel);
		}

		[TestMethod]
        [ExpectedException(typeof(NotFoundModelException))]
        public void RemoveModel_NotExistingModel_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = "OwnerName",
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
				Owner = "OwnerName",
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = "OwnerName",
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};
			_modelRepository.RemoveModel(NewModel);
			_modelRepository.GetModelsByClient("OwnerName");
		}

		[TestMethod]
		public void UpdatePreview_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Owner = "OwnerName",
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
				Owner = "OwnerName",
				Color = NewColor,
			};
			Model NewModel = new Model()
			{
				Owner = "OwnerName",
				Name = "Test",
				Material = NewMaterial,
				Figure = newFigure
			};

			Bitmap img = new Bitmap(600, 300);
			_modelRepository.AddModel(NewModel);

			_modelRepository.UpdatePreview(NewModel, img);

			Model updatedModel = _modelRepository.GetModelsByClient("OwnerName")[0];

			Assert.AreEqual(img.ToString(), updatedModel.GetPreview().ToString());
		}

	}
}

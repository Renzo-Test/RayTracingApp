using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Diagnostics.CodeAnalysis;

namespace Test.ModelsTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class ModelsTest
	{
		[TestMethod]
		public void CreateModels_OkTest()
		{
			Model newModel = new Model();
		}

		[TestMethod]
		public void SetOwner_OkTest()
		{
			Model newModel = new Model()
			{
				Owner = "ownerName"
			};
			Assert.AreEqual("ownerName", newModel.Owner);
		}

		[TestMethod]
		public void SetName_OkTest()
		{
			Model newModel = new Model()
			{
				Name = "modelName"
			};
			Assert.AreEqual("modelName", newModel.Name);
		}

		[TestMethod]
		public void SetFigure_OkTest()
		{
			Figure newFigure = new Sphere()
			{
				Name = "figureName",
				Owner = "ownerName"
			};

			Model newModel = new Model()
			{
				Figure = newFigure
			};
			Assert.AreEqual(newFigure, newModel.Figure);
		}

		[TestMethod]
		public void SetMaterial_OkTest()
		{
			Material newMaterial = new Lambertian()
			{
				Name = "materialName"
			};

			Model newModel = new Model()
			{
				Material = newMaterial
			};
			Assert.AreEqual(newMaterial, newModel.Material);
		}

		[TestMethod]
		public void SetPreview_OkTst()
		{
			Model newModel = new Model()
			{
				Preview = "modelPreview"
			};

			Assert.AreEqual("modelPreview", newModel.Preview);
		}

		[TestMethod]
		public void SetShowPreview_OkTst()
		{
			Model newModel = new Model()
			{
				showPreview = false
			};

			Assert.AreEqual(false, newModel.showPreview);
		}
	}
}

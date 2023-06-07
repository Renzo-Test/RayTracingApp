using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

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
			Material newMaterial = new Material()
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
		public void SetShowPreview_OkTst()
		{
			Model newModel = new Model()
			{
				showPreview = false
			};

			Assert.AreEqual(false, newModel.showPreview);
		}

		[TestMethod]
		public void GetPreview_OkTest()
		{
			MemoryStream ms = new MemoryStream();

			Bitmap img = new Bitmap(600, 300);
			byte[] imgByteArr = GetImageAsByteArray(ms, img);

			Model newModel = new Model()
			{
				showPreview = true,
				Preview = imgByteArr
			};

			Assert.AreEqual(newModel.GetPreview().ToString(), img.ToString());
		}

		private static byte[] GetImageAsByteArray(MemoryStream ms, Bitmap img)
		{
			img.Save(ms, ImageFormat.Bmp);
			return ms.ToArray();
		}

		[TestMethod]
		public void SetPreview_OkTest()
		{
			Bitmap img = new Bitmap(600, 300);

			Model newModel = new Model()
			{
				showPreview = true,
			};
			newModel.SetPreview(img);

			Assert.AreEqual(newModel.GetPreview().ToString(), img.ToString());
		}
	}
}

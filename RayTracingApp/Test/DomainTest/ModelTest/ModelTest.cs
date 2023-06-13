using DBRepository;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Test.ModelsTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class ModelsTest
	{
		private Client _owner;

		[TestInitialize]
		public void TestInitialize()
		{
			_owner = new Client() { Username = "ownerName" };
		}

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
				Owner = _owner
			};
			Assert.AreEqual(_owner.Username, newModel.Owner.Username);
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
				Owner = _owner
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
		public void SetShowPreview_OkTst()
		{
			Model newModel = new Model()
			{
				ShowPreview = false
			};

			Assert.AreEqual(false, newModel.ShowPreview);
		}

		[TestMethod]
		public void GetPreview_OkTest()
		{
			MemoryStream ms = new MemoryStream();

			Bitmap img = new Bitmap(600, 300);
			byte[] imgByteArr = GetImageAsByteArray(ms, img);

			Model newModel = new Model()
			{
				ShowPreview = true,
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
				ShowPreview = true,
			};
			newModel.SetPreview(img);

			Assert.AreEqual(newModel.GetPreview().ToString(), img.ToString());
		}
	}
}

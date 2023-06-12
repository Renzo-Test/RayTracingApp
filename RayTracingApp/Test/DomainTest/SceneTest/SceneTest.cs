using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace Test.ModelsTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
	public class SceneTest
	{
		private Scene _scene;
		private string _owner;
		private int _fov;
		private Vector _lookFrom;
		private Vector _looktTo;

		[TestInitialize]
		public void TestInitialize()
		{
			_owner = "ownerName";
			_fov = 70;
			_lookFrom = new Vector() { X = 1, Y = 0, Z = 1 };
			_looktTo = new Vector() { X = 0, Y = 2, Z = 1 };
		}

		[TestMethod]
		public void CreateScene_OkTest()
		{
			Scene newScene = new Scene(_owner, _fov, _lookFrom, _looktTo);
		}

		[TestMethod]
		public void SetOwner_OkTest()
		{
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Owner = "ownerName"
			};
			Assert.AreEqual("ownerName", _scene.Owner);
		}

		[TestMethod]
		public void SetName_OkTest()
		{
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Name = "modelName"
			};
			Assert.AreEqual("modelName", _scene.Name);
		}

		[TestMethod]
		public void SetRegisterTime_OkTest()
		{
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				RegisterTime = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy"),
			};
			string expected = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");

			Assert.AreEqual(expected, _scene.RegisterTime);
		}

		[TestMethod]
		public void CanGetRegisterTime_OkTest()
		{
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo);
			String today = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
			Assert.AreEqual(today, _scene.RegisterTime);
		}

		[TestMethod]
		public void CanGetLastModificationDate_OkTest()
		{
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo);
			String expected = "unmodified";
			Assert.AreEqual(expected, _scene.LastModificationDate);
		}

		[TestMethod]
		public void CanGetLastRenderDate_OkTest()
		{
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo);
			String expected = "unrendered";
			Assert.AreEqual(expected, _scene.LastRenderDate);
		}

		[TestMethod]
		public void SetFov_OkTest()
		{
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Fov = 100,
			};
			Assert.AreEqual(100, _scene.Fov);
		}

		[TestMethod]
		public void SetCameraPosition_OkTest()
		{
			Vector newCoordinate = new Vector()
			{
				X = 10,
				Y = 20,
				Z = 30,
			};

			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				CameraPosition = newCoordinate,
			};
			Assert.AreEqual(newCoordinate, _scene.CameraPosition);
		}

		[TestMethod]
		public void InitializeCameraPosition_DefaultValue_OkTest()
		{
			Vector lookFrom = new Vector()
			{
				X = 0,
				Y = 2,
				Z = 0,
			};

			_scene = new Scene(_owner, _fov, lookFrom, _looktTo);

			foreach (PropertyInfo property in lookFrom.GetType().GetProperties())
			{
				Assert.AreEqual(property.GetValue(lookFrom), property.GetValue(_scene.CameraPosition));
			}
		}

		[TestMethod]
		public void SetObjectivePosition_OkTest()
		{
			Vector newCoordinate = new Vector()
			{
				X = 10,
				Y = 20,
				Z = 30,
			};

			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				ObjectivePosition = newCoordinate,
			};
			Assert.AreEqual(newCoordinate, _scene.ObjectivePosition);
		}

		[TestMethod]
		public void InitializeObjectivePosition_DefaultValue_OkTest()
		{
			Vector lookAt = new Vector()
			{
				X = 0,
				Y = 2,
				Z = 5,
			};

			_scene = new Scene(_owner, _fov, _lookFrom, lookAt);

			foreach (PropertyInfo property in lookAt.GetType().GetProperties())
			{
				Assert.AreEqual(property.GetValue(lookAt), property.GetValue(_scene.ObjectivePosition));
			}
		}

		[TestMethod]
		public void SetPosisionatedModels_OkTest()
		{

			Vector firstCoordinate = new Vector()
			{
				X = 0,
				Y = 2,
				Z = 5,
			};

			Vector secondCoordinate = new Vector()
			{
				X = 12,
				Y = 0,
				Z = 3,
			};

			Model firstModel = new Model()
			{
				Name = "firstModelName",
				Owner = "firstOwnerName"
			};

			Model secondModel = new Model()
			{
				Name = "secondModelName",
				Owner = "secondOwnerName"
			};

			List<PosisionatedModel> posisionatedModels = new List<PosisionatedModel>()
			{
				new PosisionatedModel()
				{
					Position = firstCoordinate,
					Model = firstModel
				},

				new PosisionatedModel() {
					Position = secondCoordinate,
					Model = secondModel
				}
			};

			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				PosisionatedModels = posisionatedModels,
			};


			for (int i = 0; i < posisionatedModels.Count; i++)
			{
				foreach (PropertyInfo property in posisionatedModels[i].GetType().GetProperties())
				{
					Assert.AreEqual(property.GetValue(posisionatedModels[i]), property.GetValue(_scene.PosisionatedModels[i]));
				}
			}



		}

		[TestMethod]
		public void GetPreview_OkTest()
		{
			MemoryStream ms = new MemoryStream();

			Bitmap img = new Bitmap(600, 300);
			byte[] imgByteArr = GetImageAsByteArray(ms, img);

			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo)
			{
				Preview = imgByteArr
			};

			Assert.AreEqual(_scene.GetPreview().ToString(), img.ToString());
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
			_scene = new Scene(_owner, _fov, _lookFrom, _looktTo);
			_scene.SetPreview(img);

			Assert.AreEqual(_scene.GetPreview().ToString(), img.ToString());
		}

	}
}

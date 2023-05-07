using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
	[TestClass]
	public class RenderPropertiesTest
	{
		private RenderProperties _properties;

		[TestInitialize]
		public void TestInitialize()
		{
			_properties = new RenderProperties();
		}

		[TestMethod]
		public void CreateRenderProperties_OkTest()
		{
			RenderProperties properties = new RenderProperties();
		}

		[TestMethod]
		public void SetResolutionX_OkTest()
		{
			_properties.ResolutionX = 300;

			Assert.AreEqual(300, _properties.ResolutionX);
		}

		[TestMethod]
		public void DefaultResolutionX_OkTest()
		{
			Assert.AreEqual(300, _properties.ResolutionX);
		}

		[TestMethod]
		public void SetResolutionY_OkTest()
		{
			_properties.ResolutionY = 300;

			Assert.AreEqual(300, _properties.ResolutionY);
		}

		[TestMethod]
		public void DefaultResolutionY_OkTest()
		{

			Assert.AreEqual(200, _properties.ResolutionY);
		}

		[TestMethod]
		public void AspectRatio_OkTest()
		{
			_properties.ResolutionX = 600;
			_properties.ResolutionY = 400;
			double expected = 3.0 / 2.0;

			Assert.AreEqual(expected, _properties.AspectRatio());
		}

		[TestMethod]
		public void AspectRatio_otherValue_OkTest()
		{
			_properties.ResolutionX = 1920;
			_properties.ResolutionY = 1080;
			double expected = 16.0 / 9.0;

			Assert.AreEqual(expected, _properties.AspectRatio());
		}

		[TestMethod]
		public void SetResolutionXNotChangeAspectRatio_OkTest()
		{
			_properties.ResolutionX = 600;

			Assert.AreEqual(400, _properties.ResolutionY);
		}
	}
}

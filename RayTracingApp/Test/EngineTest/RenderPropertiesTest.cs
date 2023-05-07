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
	}
}

using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
	[TestClass]
	public class RenderPropertiesTest
	{
		[TestMethod]
		public void CreateRenderProperties_OkTest()
		{
			RenderProperties properties = new RenderProperties();
		}

		[TestMethod]
		public void SetResolutionX_OkTest()
		{
			RenderProperties properties = new RenderProperties();
			properties.ResolutionX = 300;

			Assert.AreEqual(300, properties.ResolutionX);
		}

		[TestMethod]
		public void DefaultResolutionX_OkTest()
		{
			RenderProperties properties = new RenderProperties();

			Assert.AreEqual(300, properties.ResolutionX);
		}

		[TestMethod]
		public void SetResolutionY_OkTest()
		{
			RenderProperties properties = new RenderProperties();
			properties.ResolutionY = 300;

			Assert.AreEqual(300, properties.ResolutionY);
		}
	}
}

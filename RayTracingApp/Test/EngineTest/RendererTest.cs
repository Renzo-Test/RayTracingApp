using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
	[TestClass]
	public class RendererTest
	{
		[TestMethod]
		public void CreateRenderer_OkTest()
		{
			Renderer renderer = new Renderer();
		}
	}
}

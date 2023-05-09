using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.RendererTest
{
	[TestClass]
	public class EngineTest
	{
		[TestMethod]
		public void CreateEngine_OkTest()
		{
			Engine engine = new Engine();
		}
	}
}

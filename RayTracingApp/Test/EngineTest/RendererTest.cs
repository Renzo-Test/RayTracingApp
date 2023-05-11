using Domain;
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

		[TestMethod]
		public void Render_OkTest()
		{
			Renderer renderer = new Renderer();
			Scene scene = new Scene();
			RenderProperties properties = new RenderProperties()
			{
				ResolutionX = 3,
			};
			string render = renderer.Render(scene, properties, null);

			int propertiesChars = 11;
			int pixelsChars = 12 * (properties.ResolutionX * properties.ResolutionY);
			Assert.AreEqual(propertiesChars + pixelsChars, render.Length);
		}

		[TestMethod]
		public void Render_BiggerResolution_OkTest()
		{
			Renderer renderer = new Renderer();
			Scene scene = new Scene();
			RenderProperties properties = new RenderProperties()
			{
				ResolutionX = 300,
			};
			string render = renderer.Render(scene, properties, null);

			int propertiesChars = 15;
			int pixelsChars = 12 * (properties.ResolutionX * properties.ResolutionY);
			Assert.AreEqual(propertiesChars + pixelsChars, render.Length);
		}
	}
}

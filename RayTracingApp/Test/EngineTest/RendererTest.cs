using Domain;
using Domain.Exceptions;
using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Test.EngineTest
{
	[TestClass]
	[ExcludeFromCodeCoverage]
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
			string render = renderer.Render(scene, properties, null).RenderedImage;

			int propertiesLines = 3;
			int pixelsLines = (properties.ResolutionX * properties.ResolutionY) + 1;
			Assert.AreEqual(propertiesLines + pixelsLines, CountLines(render));
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
			string render = renderer.Render(scene, properties, null).RenderedImage;

			int propertiesChars = 15;
			int pixelsChars = 12 * (properties.ResolutionX * properties.ResolutionY);
			Assert.AreEqual(propertiesChars + pixelsChars, render.Length);
		}

		[TestMethod]
		public void RenderModelPreview_OkTest()
		{
			Renderer renderer = new Renderer();
			Domain.Color modelColor = new Domain.Color { Red = 150, Green = 150, Blue = 150 };
			Model modelToPreview = new Model()
			{
				Figure = new Sphere { Radius = 5 },
				Material = new Lambertian() { Color = modelColor },
			};

			var (render, _) = renderer.RenderModelPreview(modelToPreview);

			int propertiesLines = 3;
			int pixelsLines = (100 * 100) + 1;
			Assert.AreEqual(propertiesLines + pixelsLines, CountLines(render));
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidRenderPropertiesInputException))]
		public void RenderMaxDepth0_OkTest()
		{
			RenderProperties properties = new RenderProperties()
			{
				ResolutionX = 300,
				MaxDepth = -1,
			};
		}

		private static int CountLines(string str)
		{
			int lines = 1;
			int index = 0;
			while (true)
			{
				index = str.IndexOf('\n', index);
				if (index < 0)
					break;
				lines++;
				index++;
			}
			return lines;
		}

	}
}

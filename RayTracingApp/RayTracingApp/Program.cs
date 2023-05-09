using Domain;
using Engine;
using System.Collections.Generic;

namespace RayTracingApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Figure sphere1 = new Sphere()
			{
				Radius = 0.5,
			};

			Figure sphere2 = new Sphere()
			{
				Radius = 0.5,
			};

			Figure sphere3 = new Sphere()
			{
				Radius = 2,
			};

			Figure terrain = new Sphere()
			{
				Radius = 2000,
			};

			Material material1 = new Material()
			{
				Color = new Color() { Red = 26, Green = 51, Blue = 128 },
				Type = MaterialEnum.LambertianMaterial
			};
			Material material2 = new Material()
			{
				Color = new Color() { Red = 204, Green = 51, Blue = 128 },
				Type = MaterialEnum.LambertianMaterial
			};
			Material material3 = new Material()
			{
				Color = new Color() { Red = 204, Green = 64, Blue = 13 },
				Type = MaterialEnum.LambertianMaterial
			};
			Material materialTerrain = new Material()
			{
				Color = new Color() { Red = 179, Green = 179, Blue = 26 },
				Type = MaterialEnum.LambertianMaterial
			};

			Model model1 = new Model()
			{
				Figure = sphere1,
				Material = material1,
			};
			Model model2 = new Model()
			{
				Figure = sphere2,
				Material = material2,
			};
			Model model3 = new Model()
			{
				Figure = sphere3,
				Material = material3,
			};
			Model modelTerrain = new Model()
			{
				Figure = terrain,
				Material = materialTerrain,
			};

			PosisionatedModel pm1 = new PosisionatedModel()
			{
				Model = model1,
				Position = new Vector() { X = 0, Y = 0.5, Z = -2 },
			};
			PosisionatedModel pm2 = new PosisionatedModel()
			{
				Model = model1,
				Position = new Vector() { X = -1, Y = 0.5, Z = -2 },
			};
			PosisionatedModel pm3 = new PosisionatedModel()
			{
				Model = model1,
				Position = new Vector() { X = -1, Y = -2, Z = -10 },
			};
			PosisionatedModel pmTerrain = new PosisionatedModel()
			{
				Model = model1,
				Position = new Vector() { X = 0, Y = -2000, Z = -1 },
			};

			List<PosisionatedModel> listPM = new List<PosisionatedModel>()
			{
				pm1,
				pm2,
				pm3,
				pmTerrain
			};

			Scene scene = new Scene()
			{
				CameraPosition = new Vector() { X = 4, Y = 2, Z = 0 },
				ObjectivePosition = new Vector() { X = 0, Y = 0.5, Z = -2 },
				Fov = 40,
				PosisionatedModels = listPM
			};

			RenderProperties properties = new RenderProperties()
			{
				ResolutionX = 300,
				ResolutionY = 200,
				SamplesPerPixel = 100,
				MaxDepth = 100,
			};

			Renderer renderer = new Renderer();
			renderer.Scene = scene;
			renderer.Properties = properties;
			renderer.Render();
		}
	}
}

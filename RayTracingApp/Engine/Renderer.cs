using Domain;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Engine
{
	public class Renderer
	{
		public Scene Scene;
		public RenderProperties Properties;

		private Printer _printer;
		private List<List<Vector>> _pixels;
		private Progress _progress;
		private Camera _camera;

		private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());

		public string Render(Scene scene, RenderProperties properties, ProgressBar progressBar)
		{
			Scene = scene;
			Properties = properties;
			InitializateRender(progressBar);

			int row = Properties.ResolutionY - 1;
			Parallel.For(0, row + 1, index =>
			{
				int derivatedIndex = row - index;
				for (int column = 0; column < Properties.ResolutionX; column++)
				{
					Vector vector = new Vector()
					{
						X = 0,
						Y = 0,
						Z = 0
					};

					Antialiasing(derivatedIndex, column, ref vector);

					vector = vector.Divide(Properties.SamplesPerPixel);
					SavePixel(derivatedIndex, column, vector, Properties.ResolutionY, _pixels);
				}

				_progress.UpdateProgressBar();
				_progress.WriteCurrentPercentage();

			});

			return _printer.Save(_pixels, Properties, ref _progress);
		}

		public string RenderModelPreview(Model model)
		{
			RenderProperties properties = PreviewRenderProperties();
			Scene previewScene = CreatePreviewScene(model);

			string preview = Render(previewScene, properties, null);
			model.Preview = preview;
			return preview;
		}

		private void InitializateRender(ProgressBar progressBar)
		{
			_progress = new Progress()
			{
				ProgressBar = progressBar,
			};
			_progress.ExpectedLines = (Properties.ResolutionY * Properties.ResolutionX * Properties.SamplesPerPixel) + Properties.ResolutionY;
			_printer = new Printer();
			InitializateCamera(Scene, Properties);
			InitializatePixels(ref _pixels);
		}

		private void Antialiasing(int derivatedIndex, int column, ref Vector vector)
		{
			for (int sample = 0; sample < Properties.SamplesPerPixel; sample++)
			{
				double fstRnd = random.Value.NextDouble();
				double sndRnd = random.Value.NextDouble();

				double u = (column + fstRnd) / Properties.ResolutionX;
				double v = (derivatedIndex + sndRnd) / Properties.ResolutionY;

				var ray = _camera.GetRay(u, v);
				vector.AddFrom(ShootRay(ray, Properties.MaxDepth, Scene.PosisionatedModels));
				_progress.Count(); ;
			}
		}

		private void InitializatePixels(ref List<List<Vector>> pixels)
		{
			pixels = new List<List<Vector>>();
			for (int i = 0; i < Properties.ResolutionY; i++)
			{
				pixels.Add(new List<Vector>());
			}
		}

		private void InitializateCamera(Scene scene, RenderProperties properties)
		{
			Vector LookFrom = scene.CameraPosition;
			Vector LookAt = scene.ObjectivePosition;
			Vector VectorUp = new Vector() { X = 0, Y = 1, Z = 0 };
			int FieldOfView = scene.Fov;
			double AspectRatio = properties.AspectRatio;
			_camera = new Camera(LookFrom, LookAt, VectorUp, FieldOfView, AspectRatio);
		}

		private Scene CreatePreviewScene(Model model)
		{
			Sphere figurePreview = new Sphere()
			{
				Radius = 1
			};
			Model modelToPreview = new Model()
			{
				Figure = figurePreview,
				Material = model.Material,
			};
			PosisionatedModel posisionatedModel = new PosisionatedModel()
			{
				Model = modelToPreview,
				Position = new Vector() { Y = 1}
			};

			Sphere terrain = new Sphere()
			{
				Radius = 2000
			};
			Domain.Color terrainColor = new Domain.Color { Red = 150, Green = 150, Blue = 150 };
			Model modelTerrain = new Model()
			{
				Figure = terrain,
				Material = new Material() { Color = terrainColor, Type = MaterialEnum.LambertianMaterial }
			};
			PosisionatedModel terrainPosisionated = new PosisionatedModel()
			{
				Model = modelTerrain,
				Position = new Vector() { Y = -2000},
			};
			Scene previewScene = new Scene()
			{
				CameraPosition = new Vector { X = -5, Y = 4, Z = 0 },
				ObjectivePosition = new Vector() { Y = 1},
				Fov = 30
			};
			previewScene.PosisionatedModels.Add(posisionatedModel);
			previewScene.PosisionatedModels.Add(terrainPosisionated);

			return previewScene;
		}

		private RenderProperties PreviewRenderProperties()
		{
			RenderProperties properties = new RenderProperties()
			{
				AspectRatio = 1,
				ResolutionX = 100,
				SamplesPerPixel = 20,
			};

			return properties;
		}

		private void SavePixel(int row, int column, Vector pixelRGB, int resolutionY, List<List<Vector>> pixels)
		{
			int posX = column;
			int posY = resolutionY - row - 1;

			if (posY < resolutionY)
			{
				pixels[posY].Add(pixelRGB);
			}
			else
			{
				throw new Exception("Pixel Overflow Error");
			}
		}

		private Vector ShootRay(Ray ray, int depth, List<PosisionatedModel> posisionatedModels)
		{
			HitRecord hitRecord = null;
			double tMax = 3.4 * Math.Pow(10, 38);

			foreach (PosisionatedModel posisionatedModel in posisionatedModels)
			{
				HitRecord hit = IsSphereHit(posisionatedModel, ray, 0.001, tMax);
				if (hit is object)
				{
					hitRecord = hit;
					tMax = hit.T;
				}
			}

			if (hitRecord is object)
			{
				if (depth > 0)
				{
					Vector newVectorPoint = hitRecord.Intersection.Add(hitRecord.Normal).Add(GetRandomInUnitSphere());
					Vector newVector = newVectorPoint.Substract(hitRecord.Intersection);

					Ray newRay = new Ray()
					{
						Origin = hitRecord.Intersection,
						Direction = newVector
					};

					Vector color = ShootRay(newRay, depth - 1, posisionatedModels);
					Vector attenuation = hitRecord.Attenuation;

					return new Vector()
					{
						X = color.X * attenuation.X,
						Y = color.Y * attenuation.Y,
						Z = color.Z * attenuation.Z
					};
				}
				else
				{
					Vector vector = new Vector()
					{
						X = 0,
						Y = 0,
						Z = 0
					};
					return vector;
				}

			}
			else
			{
				Vector vectorDirectionUnit = ray.Direction.GetUnit();
				double posY = 0.5 * (vectorDirectionUnit.Y + 1);
				Vector colorStart = new Vector()
				{
					X = 1,
					Y = 1,
					Z = 1
				};
				Vector colorEnd = new Vector()
				{
					X = 0.5,
					Y = 0.7,
					Z = 1
				};
				return colorStart.Multiply(1 - posY).Add(colorEnd.Multiply(posY));
			}
		}

		private HitRecord IsSphereHit(PosisionatedModel posisionatedModel, Ray ray, double tMin, double tMax)
		{
			Sphere sphere = (Sphere)posisionatedModel.Model.Figure;
			Vector position = posisionatedModel.Position;
			Vector vectorOriginCenter = ray.Origin.Substract(position);
			double a = ray.Direction.Dot(ray.Direction);
			double b = vectorOriginCenter.Dot(ray.Direction) * 2;
			double c = vectorOriginCenter.Dot(vectorOriginCenter) - (sphere.Radius * sphere.Radius);
			double discriminant = (b * b) - (4 * a * c);
			

			if (discriminant < 0)
			{
				return null;
			}
			else
			{
				double t = ((-1 * b) - Math.Sqrt(discriminant)) / (2 * a);
				Vector intersectionPoint = ray.PointAt(t);
				Vector Normal = intersectionPoint.Substract(position).Divide(sphere.Radius);
				
				if (t < tMax && t > tMin)
				{
					return new HitRecord()
					{
						T = t,
						Intersection = intersectionPoint,
						Normal = Normal,
						Attenuation = posisionatedModel.Model.Material.Color.ColorToVector(),
					};
				}
				else
				{
					return null;
				}
			}
		}

		private Vector GetRandomInUnitSphere()
		{
			Vector vector;
			do
			{
				Vector vectorTemp = new Vector()
				{
					X = random.Value.NextDouble(),
					Y = random.Value.NextDouble(),
					Z = random.Value.NextDouble(),
				};
				Vector vectorSubstract = new Vector()
				{
					X = 1,
					Y = 1,
					Z = 1,
				};
				vector = vectorTemp.Multiply(2).Substract(vectorSubstract);
			} while (vector.SquaredLength() >= 1);

			return vector;
		}
	}
}

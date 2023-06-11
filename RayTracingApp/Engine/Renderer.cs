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
		private Scene _scene;
		private RenderProperties _properties;

		private Printer _printer;
		private List<List<Vector>> _pixels;
		private Progress _progress;
		private Camera _camera;

		private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());

		public string Render(Scene scene, RenderProperties properties, ProgressBar progressBar)
		{
			_scene = scene;
			_properties = properties;
			InitializateRender(progressBar);

			int row = _properties.ResolutionY - 1;
			Parallel.For(0, row + 1, index =>
			{
				int derivatedIndex = row - index;
				for (int column = 0; column < _properties.ResolutionX; column++)
				{
                    Vector vector = InitializeEmptyVector();

                    Antialiasing(derivatedIndex, column, ref vector);

					vector = vector.Divide(_properties.SamplesPerPixel);
					SavePixel(derivatedIndex, column, vector);
				}

                _progress.UpdateProgressBar();
				_progress.WriteCurrentPercentage();

			});

			return _printer.Save(_pixels, _properties, ref _progress);
		}

        private static Vector InitializeEmptyVector()
        {
            return new Vector()
            {
                X = 0,
                Y = 0,
                Z = 0
            };
        }

		public (string, Image) RenderModelPreview(Model model)
		{
			RenderProperties properties = PreviewRenderProperties();
			Scene previewScene = CreatePreviewScene(model);

			string preview = Render(previewScene, properties, null);
			Scanner scanner = new Scanner();
			Bitmap img = scanner.ScanImage(preview);

			return (preview, img);
		}

		private void InitializateRender(ProgressBar progressBar)
		{
			_progress = new Progress()
			{
				ProgressBar = progressBar,
			};
			_progress.ExpectedLines = (_properties.ResolutionY * _properties.ResolutionX * _properties.SamplesPerPixel) + _properties.ResolutionY;
			_printer = new Printer();
			InitializateCamera(_scene, _properties);
			InitializatePixels(ref _pixels);
		}

		private void InitializateCamera(Scene scene, RenderProperties properties)
		{
			Vector LookFrom = scene.LookFrom;
			Vector LookAt = scene.LookAt;
			Vector VectorUp = new Vector() { X = 0, Y = 1, Z = 0 };
			int FieldOfView = scene.Fov;
			double AspectRatio = properties.AspectRatio;
			double focalDistance = LookFrom.Substract(LookAt).Length();
			double aperture = scene.LensAperture;
			_camera = new Camera(LookFrom, LookAt, VectorUp, FieldOfView, AspectRatio, aperture, focalDistance);
		}

		private void InitializatePixels(ref List<List<Vector>> pixels)
		{
			pixels = new List<List<Vector>>();
			for (int i = 0; i < _properties.ResolutionY; i++)
			{
				pixels.Add(new List<Vector>());
			}
		}

		private void Antialiasing(int derivatedIndex, int column, ref Vector vector)
		{
			for (int sample = 0; sample < _properties.SamplesPerPixel; sample++)
			{
				double fstRnd = random.Value.NextDouble();
				double sndRnd = random.Value.NextDouble();

				double u = (column + fstRnd) / _properties.ResolutionX;
				double v = (derivatedIndex + sndRnd) / _properties.ResolutionY;

				var ray = _camera.GetRay(u, v, GetRandomInUnitSphere());
				vector.AddFrom(ShootRay(ray, _properties.MaxDepth));
				_progress.Count(); ;
			}
		}

		private Vector ShootRay(Ray ray, int depth)
		{
			HitRecord hitRecord = null;
			double tMax = 3.4 * Math.Pow(10, 38);

			foreach (PosisionatedModel posisionatedModel in _scene.PosisionatedModels)
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
				Ray newRay = null;

				if(hitRecord.Material.Type is MaterialEnum.Lambertian)
				{
					newRay = LambertianScatter(hitRecord);
				}
				else if(hitRecord.Material.Type is MaterialEnum.Metallic)
				{
					newRay = MetailcScatter(ray, hitRecord);
					if(newRay is null)
					{
						return new Vector() { X = 0, Y = 0, Z = 0 };
					}
				}

				Vector color = ShootRay(newRay, depth - 1);
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
						Material = posisionatedModel.Model.Material,
						Roughness = posisionatedModel.Model.Material.Blur,
					};
				}
				else
				{
					return null;
				}
			}
		}

		private Ray LambertianScatter(HitRecord hitRecord)
		{
			Vector newVectorPoint = hitRecord.Intersection
				.Add(hitRecord.Normal)
				.Add(GetRandomInUnitSphere());
			Vector newVector = newVectorPoint
				.Substract(hitRecord.Intersection);

			Ray newRay = new Ray()
			{
				Origin = hitRecord.Intersection,
				Direction = newVector
			};

			return newRay;
		}

		private Ray MetailcScatter(Ray rayIn, HitRecord hitRecord)
		{
			Ray rayScattered = new Ray()
			{
				Direction = new Vector() { X = 0, Y = 0, Z = 0 },
				Origin = new Vector() { X = 0, Y = 0, Z = 0 }
			};

			Vector vectorReflected = Reflect(rayIn.Direction.GetUnit(), hitRecord.Normal);
			rayScattered.Origin = hitRecord.Intersection;
			rayScattered.Direction = vectorReflected.Add(
				GetRandomInUnitSphere().Multiply(hitRecord.Roughness));

			if (rayScattered.Direction.Dot(hitRecord.Normal) > 0)
			{
				return rayScattered;
			}
			else
			{
				return null;
			}
		}

		private Vector Reflect(Vector vector, Vector normal)
		{
			return vector.Substract(normal.Multiply(vector.Dot(normal) * 2));
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

		private void SavePixel(int row, int column, Vector pixelRGB)
		{
			int posX = column;
			int posY = _properties.ResolutionY - row - 1;

			if (posY < _properties.ResolutionY)
			{
				_pixels[posY].Add(pixelRGB);
			}
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

		private Scene CreatePreviewScene(Model model)
		{
			Sphere figurePreview = InitializateSphere(1);
			Model modelToPreview = InitializateModel(figurePreview, model.Material);
			PosisionatedModel posisionatedModel = InitializatePosisionatedModel(modelToPreview, 1);


			Sphere terrain = InitializateSphere(2000);
			Domain.Color terrainColor = new Domain.Color { Red = 150, Green = 150, Blue = 150 };
			Model modelTerrain = InitializateModel(terrain, new Lambertian() { Color = terrainColor});
			PosisionatedModel terrainPosisionated = InitializatePosisionatedModel(modelTerrain, -2000);

			Scene previewScene = new Scene()
			{
				LookFrom = new Vector { X = -5, Y = 4, Z = 0 },
				LookAt= new Vector() { Y = 1 },
				Fov = 30
			};
			previewScene.PosisionatedModels.Add(posisionatedModel);
			previewScene.PosisionatedModels.Add(terrainPosisionated);

			return previewScene;
		}

		private static PosisionatedModel InitializatePosisionatedModel(Model model, double y)
		{
			return new PosisionatedModel()
			{
				Model = model,
				Position = new Vector() { Y = y }
			};
		}

		private static Model InitializateModel(Figure figure, Material material)
		{
			return new Model()
			{
				Figure = figure,
				Material = material,
			};
		}

		private static Sphere InitializateSphere(double radius)
		{
			return new Sphere()
			{
				Radius = radius
			};
		}
	}
}

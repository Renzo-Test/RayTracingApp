using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Engine
{
	public class Renderer
	{
		public RenderProperties Properties;
		public Scene Scene;

		private Printer _printer;
		private List<List<Vector>> _pixels;
		private Progress _progress;
		private Camera _camera;

		private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random());

		public string Render(ProgressBar progressBar)
		{
			_progress = new Progress() 
			{ 
				ProgressBar = progressBar,
			};
			_pixels = new List<List<Vector>>();
			_printer = new Printer();
				
			Vector LookFrom = Scene.CameraPosition;
			Vector LookAt = Scene.ObjectivePosition;
			Vector VectorUp = new Vector() { X = 0, Y = 1, Z = 0 };
			int FieldOfView = Scene.Fov;
			double AspectRatio = Properties.AspectRatio;
			_camera = new Camera(LookFrom, LookAt, VectorUp, FieldOfView, AspectRatio);

			_progress.ExpectedLines = (Properties.ResolutionY * Properties.ResolutionX * Properties.SamplesPerPixel) + Properties.ResolutionY;


			for (int i = 0; i < Properties.ResolutionY; i++)
			{
				_pixels.Add(new List<Vector>());
			}

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

					for (int sample = 0; sample < Properties.SamplesPerPixel; sample++)
					{
						double fstRnd = random.Value.NextDouble();
						double sndRnd = random.Value.NextDouble();

						double u = (column + fstRnd) / Properties.ResolutionX;
						double v = (derivatedIndex + sndRnd) / Properties.ResolutionY;

						var ray = _camera.GetRay(u, v);
						vector.AddFrom(ShootRay(ray, Properties.MaxDepth));
						_progress.Count();
					}
					vector = vector.Divide(Properties.SamplesPerPixel);
					SavePixel(derivatedIndex, column, vector);
				}

				_progress.UpdateProgressBar();
				_progress.WriteCurrentPercentage();
			
			});
			return _printer.Save(_pixels, Properties, ref _progress);
		}

		private void SavePixel(int row, int column, Vector pixelRGB)
		{
			int posX = column;
			int posY = Properties.ResolutionY - row - 1;

			if (posY < Properties.ResolutionY)
			{
				_pixels[posY].Add(pixelRGB);
			}
			else
			{
				throw new Exception("Pixel Overflow Error");
			}
		}

		private Vector ShootRay(Ray ray, int depth)
		{
			HitRecord hitRecord = null;
			double tMax = 3.4 * Math.Pow(10, 38);

			foreach (PosisionatedModel posisionatedModel in Scene.PosisionatedModels)
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

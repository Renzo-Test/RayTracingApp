
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
	public class Printer
	{
		public string Save(List<List<Vector>> Pixels, RenderProperties properties, ref Progress progress)
		{
			StringBuilder image = InitializateImage(properties);

			if (Pixels.Any())
			{
				for (var j = 0; j < properties.ResolutionY; j++)
				{
					for (var i = 0; i < properties.ResolutionX; i++)
					{
						Color color = GetColor(Pixels, j, i);

						AppendColor(image, color);

						progress.Count();
						progress.UpdateProgressBar();
					}
				}
			}

			return image.ToString();
		}

		private static void AppendColor(StringBuilder image, Color color)
		{
			image.Append($"{color.Red} {color.Green} {color.Blue}\n");
		}

		private static Color GetColor(List<List<Vector>> Pixels, int j, int i)
		{
			return Pixels[j][i].Color();
		}

		private static StringBuilder InitializateImage(RenderProperties properties)
		{
			string imageString = $"P3\n{properties.ResolutionX} {properties.ResolutionY}\n255\n";
			StringBuilder sb = new StringBuilder();
			sb.Append(imageString);
			return sb;
		}
	}
}

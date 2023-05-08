using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Printer
    {
        public string Save(List<List<Color>> Pixels, RenderProperties properties, ref Progress progress)
        {
            string imageString = InitializeImageProperties(properties);
			StringBuilder sb = new StringBuilder();
			sb.Append(imageString);

			if (Pixels.Any())
			{
				for (var j = 0; j < properties.ResolutionY; j++)
				{
					for (var i = 0; i < properties.ResolutionX; i++)
					{
						Color color = Pixels[j][i];
						sb.Append($"{color.Red} {color.Green} {color.Blue}\n");
						progress.Count();
					}
				}
			}

			return sb.ToString();
		}

        private static string InitializeImageProperties(RenderProperties properties)
        {
			return $"P3\n{properties.ResolutionX} {properties.ResolutionY}\n255\n";
		}
    }
}

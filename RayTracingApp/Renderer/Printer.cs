using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Renderer
{
    public class Printer
    {
        public string Save(List<List<Color>> Pixels, RenderProperties properties, ref Progress progress)
        {
            StringBuilder image = InitializateImage(properties);

			if (Pixels.Any())
			{
				for (var j = 0; j < properties.ResolutionY; j++)
				{
					for (var i = 0; i < properties.ResolutionX; i++)
					{
						Color color = Pixels[j][i];
						image.Append($"{color.Red} {color.Green} {color.Blue}\n");
						progress.Count();
					}
				}
			}

			return image.ToString();
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

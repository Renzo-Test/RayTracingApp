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
        public string Save(List<List<Color>> Pixels, RenderProperties properties, Progress progress)
        {
            string imageString = InitializeImageProperties(properties);

			for (var j = 0; j < properties.ResolutionY; j++)
			{
				for (var i = 0; i < properties.ResolutionX; i++)
				{
					Color color = Pixels[j][i];
					imageString += color.Red + " " + color.Green + " " + color.Blue + "\n";
				}
			}

			return imageString;
		}

        private static string InitializeImageProperties(RenderProperties properties)
        {
			return $"P3\n{properties.ResolutionX} {properties.ResolutionY}\n255\n";
		}
    }
}

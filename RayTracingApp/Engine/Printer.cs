
using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

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
						Color color = Pixels[j][i].Color();
						image.Append($"{color.Red} {color.Green} {color.Blue}\n");
						progress.Count();
						progress.UpdateProgressBar();
					}
				}
			}

			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			File.WriteAllText($"{path}/prueba.ppm", image.ToString());
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

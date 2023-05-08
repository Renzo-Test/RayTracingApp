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
            return InitializeImageProperties(properties);
		}

        private static string InitializeImageProperties(RenderProperties properties)
        {
			return $"P3\n {properties.ResolutionX} {properties.ResolutionY} \n255\n";
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.RenderProperties.Exceptions
{
	internal class InputLowerThanZero : InvalidRenderPropertiesInputException
	{
		public InputLowerThanZero (string message) : base (message) { }
	}
}

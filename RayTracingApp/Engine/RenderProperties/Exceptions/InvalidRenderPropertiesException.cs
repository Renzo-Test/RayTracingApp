using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.RenderProperties.Exceptions
{
	public class InvalidRenderPropertiesInputException : Exception
	{
		public InvalidRenderPropertiesInputException(string message) : base(message) { }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Exceptions
{
	internal class ExporterException : Exception
	{
		public ExporterException(string message) : base(message) { }
	}
}

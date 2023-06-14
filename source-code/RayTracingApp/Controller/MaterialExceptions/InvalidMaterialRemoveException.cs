using System;

namespace Controller.Exceptions
{
	public class InvalidMaterialRemoveException : Exception
	{
		public InvalidMaterialRemoveException(string message) : base(message) { }
	}
}

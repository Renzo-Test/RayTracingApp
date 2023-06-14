using System;

namespace DBRepository.Exceptions
{
	public class NotFoundMaterialException : Exception
	{
		public NotFoundMaterialException(string message) : base(message) { }
	}
}

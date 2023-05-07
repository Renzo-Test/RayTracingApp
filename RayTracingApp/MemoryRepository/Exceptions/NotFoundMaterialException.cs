using System;

namespace MemoryRepository.Exceptions
{
	public class NotFoundMaterialException : Exception
	{
		public NotFoundMaterialException(string message) : base(message) { }
	}
}

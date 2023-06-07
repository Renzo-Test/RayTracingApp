using System;

namespace DBRepository.Exceptions
{
	public class NotFoundFigureException : Exception
	{
		public NotFoundFigureException(string message) : base(message) { }
	}
}

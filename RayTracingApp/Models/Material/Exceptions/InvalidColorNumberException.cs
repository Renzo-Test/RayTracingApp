using System;

namespace Models.MaterialExceptions
{
	public class InvalidColorNumberException : Exception
	{
		public InvalidColorNumberException(string message) : base(message) { }
	}
}

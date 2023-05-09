using Domain.Exceptions;
using System;

namespace Domain
{
	public class Sphere : Figure
	{
		public Double Radius { get; set; }

		private const string SmallerThanCeroRadiusMessage = "Sphere's radius must be greater than cero";

		public override void FigurePropertiesAreValid()
		{
			if (!RadiusGreaterThanZero())
			{
				throw new SmallerThanCeroRadiusException(SmallerThanCeroRadiusMessage);
			}
		}

		private bool RadiusGreaterThanZero()
		{
			return Radius > 0;
		}
	}
}

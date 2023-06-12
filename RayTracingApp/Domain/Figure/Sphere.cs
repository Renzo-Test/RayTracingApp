using Domain.Exceptions;

namespace Domain
{
	public class Sphere : Figure
	{
		private const string SmallerThanCeroRadiusMessage = "Sphere's radius must be greater than cero";

		public double Radius { get; set; }

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

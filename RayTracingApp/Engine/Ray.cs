namespace Engine
{
	public class Ray
	{
		public Vector Origin { get; set; }
		public Vector Direction { get; set; }

		public Vector PointAt(double multiplier)
		{
			return Origin.Add(Direction.Multiply(multiplier));
		}
	}
}

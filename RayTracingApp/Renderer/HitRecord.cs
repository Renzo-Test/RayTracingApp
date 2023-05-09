namespace Renderer
{
	public class HitRecord
	{
		public double T { get; set; }
		public Vector Intersection { get; set; }
		public Vector Normal { get; set; }
		public Vector Attenuation { get; set; }
	}
}

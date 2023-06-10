namespace Domain
{
	public class PosisionatedModel
	{
        public int Id { get; set; }
		public Scene ModelScene { get; set; }
		public int SceneId { get; set; }
        public Vector Position { get; set; }
		public Model Model { get; set; }
	}
}

namespace Models
{
    public class Material
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public MaterialEnum Type { get; set; }
    }

    public enum MaterialEnum
    {
        LambertianMaterial
    }
}

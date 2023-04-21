using System;
using System.Collections.Generic;

namespace Models
{
    public class Scene
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string RegisterTime { get; set; } = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
        public string LastModificationDate { get; set; } = "unmodified";
        public string LastRenderDate { get; set; } = "unrendered";
        public int Fov { get; set; } = 30;
        public Coordinate CameraPosition { get; set; } = new Coordinate() { X = 0, Y = 2, Z = 0 };
        public Coordinate ObjectivePosition { get; set; } = new Coordinate() { X = 0, Y = 2, Z = 5 };
        public List<PosisionatedModel> PosisionatedModels { get; set; }
    }
}

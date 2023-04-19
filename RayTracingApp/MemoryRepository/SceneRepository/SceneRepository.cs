using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryRepository
{
    public class SceneRepository
    {
        private readonly List<Scene> _scenes;

        public SceneRepository()
        {
            _scenes = new List<Scene>();
        }
        public void AddScene(Scene scene)
        {
            _scenes.Add(scene);
        }

        public List<Scene> GetScenesByClient(string v)
        {
            return _scenes;
        }
    }
}

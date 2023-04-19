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
        private Scene _scene;

        public void AddScene(Scene scene)
        {
            _scene = scene;
        }

        public List<Scene> GetScenesByClient(string v)
        {
            return new List<Scene>()
            {
                _scene,
            };
        }
    }
}

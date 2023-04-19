using IRepository;
using MemoryRepository.Exceptions;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryRepository
{
    public class SceneRepository : IRepositoryScene
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

        public List<Scene> GetScenesByClient(string username)
        {
            List<Scene> foundScenes = _scenes.FindAll(scene => scene.Owner.Equals(username));
            if (!foundScenes.Any())
            {
                string NotFoundScenelMessage = $"no scene with owner: {username} was found";
                throw new NotFoundSceneException(NotFoundScenelMessage);
            }
            return foundScenes;
        }

        public void RemoveScene(Scene scene)
        {
            _scenes.Remove(scene);
        }
    }
}

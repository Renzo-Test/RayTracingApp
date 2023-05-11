using IRepository;
using Domain;
using System.Collections.Generic;
using MemoryRepository.Exceptions;

namespace MemoryRepository
{
    public class SceneRepository : IRepositoryScene
    {
        private const string NotFoundSceneMessage = "Scene was not found or already deleted";
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
            return foundScenes;
        }

        public void RemoveScene(Scene scene)
        {
            if (!_scenes.Remove(scene))
            {
                throw new NotFoundSceneException(NotFoundSceneMessage);
            }
            else
            {
                _scenes.Remove(scene);
            }
        }
    }
}

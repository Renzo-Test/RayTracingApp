using IRepository;
using Models;
using System.Collections.Generic;

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
			return foundScenes;
		}

		public void RemoveScene(Scene scene)
		{
			_scenes.Remove(scene);
		}
	}
}

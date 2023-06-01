using Domain;
using System.Collections.Generic;
using System.Drawing;

namespace IRepository
{
	public interface IRepositoryScene
	{
		List<Scene> GetScenesByClient(string username);
		void AddScene(Scene scene);
		void RemoveScene(Scene scene);
		void UpdateSceneName(Scene scene, string newName);
		void UpdateScenePreview(Scene scene, Bitmap preview);

    }
}

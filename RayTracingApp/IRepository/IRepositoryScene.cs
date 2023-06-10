using Domain;
using System.Collections.Generic;
using System.Drawing;

namespace IRepository
{
	public interface IRepositoryScene
	{
		void AddScene(Scene scene);
		void RemoveScene(Scene scene);
		void UpdateSceneName(Scene scene, string newName);
		void UpdateScenePreview(Scene scene, Bitmap preview);
		void UpdateSceneModels(Scene scene, PosisionatedModel model);
		void RemoveSceneModels(Scene scene, PosisionatedModel model);
		List<Scene> GetScenesByClient(string username);
		List<PosisionatedModel> GetPosisionatedModels(Scene scene);
	}
}
